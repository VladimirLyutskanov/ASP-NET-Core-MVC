using LibraryData;
using LibraryData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace LibraryServices
{
    public class CheckoutService : ICheckout
    {
        private readonly LibraryDbContext context;

        public CheckoutService(LibraryDbContext context)
        {
            this.context = context;
        }
        public void Add(Checkout newCheckout)
        {
            context.Add(newCheckout);
            context.SaveChanges();
        }

        public Checkout GetById(int checkoutId)
        {
            return context.Checkouts.FirstOrDefault(checkout => checkout.Id == checkoutId);
            //return GetAll().FirstOrDefault(checkout => checkout.Id == checkoutId);
        }

        public IEnumerable<Checkout> GetAll()
        {
            return context.Checkouts;
        }

        public IEnumerable<CheckoutHistory> GetCheckoutHistory(int id)
        {
            return context.CheckoutHistories
                .Include(h => h.LibraryAsset)
                .Include(h => h.LibraryCard)
                .Where(h => h.LibraryAsset.Id == id);
        }


        public IEnumerable<Hold> GetCurrentHolds(int id)
        {
            return context.Holds.Include(h => h.LibraryAsset)
                .Where(h => h.LibraryAsset.Id == id);
        }
        public Checkout GetLatestCheckout(int assetid)
        {
            return context.Checkouts
                 .Where(c => c.LibraryAsset.Id == assetid)
                 .OrderByDescending(c => c.Since)
                 .FirstOrDefault();
        }

        public void MarkFound(int assetid)
        {
            var now = DateTime.Now;
            var item = context.LibraryAssets.FirstOrDefault(i => i.Id == assetid);
            context.Update(item);
            item.Status = context.Statuses.FirstOrDefault(status => status.Name=="Available");
            //item.Status = context.Statuses.Find("Available"); !!!!

            RemoveExistingCheckouts(assetid);

            CloseExistingCheckoutHistory(assetid,now);     
            
            context.SaveChanges();
        }
        public void MarkLost(int assetid)
        {
          
            var item = context.LibraryAssets.FirstOrDefault(i => i.Id == assetid);
            context.Update(item);
            //item.Status = context.Statuses.Find("Lost"); !!!!
            item.Status = context.Statuses.FirstOrDefault(status => status.Name=="Lost");
            context.SaveChanges();

        }

        public void CheckInItem(int id)
        {
            var now = DateTime.Now;

            var item = context.LibraryAssets
                .First(a => a.Id == id);

            context.Update(item);

            // remove any existing checkouts on the item
            var checkout = context.Checkouts
                .Include(c => c.LibraryAsset)
                .Include(c => c.LibraryCard)
                .FirstOrDefault(a => a.LibraryAsset.Id == id);
            if (checkout != null) context.Remove(checkout);

            // close any existing checkout history
            var history = context.CheckoutHistories
                .Include(h => h.LibraryAsset)
                .Include(h => h.LibraryCard)
                .FirstOrDefault(h =>
                    h.LibraryAsset.Id == id
                    && h.CheckedIn == null);
            if (history != null)
            {
                context.Update(history);
                history.CheckedIn = now;
            }

            // look for current holds
            var currentHolds = context.Holds
                .Include(a => a.LibraryAsset)
                .Include(a => a.LibraryCard)
                .Where(a => a.LibraryAsset.Id == id);

            // if there are current holds, check out the item to the earliest
            if (currentHolds.Any())
            {
                CheckoutForEarliestHold(id, currentHolds);
                return;
            }

            // otherwise, set item status to available
            item.Status = context.Statuses.FirstOrDefault(a => a.Name == "Available");

            context.SaveChanges();
        }

        private void CheckoutForEarliestHold(int assetId, IQueryable<Hold> currentHolds)
        {
            var earliestHold = currentHolds.OrderBy(holds => holds.HoldPlaced)
                .FirstOrDefault();

            var card = earliestHold.LibraryCard;
            context.Remove(earliestHold);
            context.SaveChanges();

            CheckoutItem(assetId, card.Id);
        }

        public void CheckoutItem(int assetId, int libraryCardId)
        {
            if (IsCheckedOut(assetId))
            {
                return;
                //addlogic to send feedback to the user
            }

            var item = context.LibraryAssets
                .FirstOrDefault(i => i.Id == assetId);

            context.Update(item);

            item.Status = context.Statuses.FirstOrDefault(status => status.Name == "Checked Out");

            var libraryCard = context.LibraryCards
                .Include(card => card.Checkouts)
                .FirstOrDefault(card => card.Id == libraryCardId);

            var now = DateTime.Now;

            var checkout = new Checkout
            {
                LibraryAsset = item,
                LibraryCard = libraryCard,
                Since = now,
                Untill = GetDefaultCheckoutTime(now)
            };

            context.Add(checkout);

            var checkouHistory = new CheckoutHistory
            {
                CheckedOut=now,
                LibraryAsset = item,
                LibraryCard=libraryCard
            };

            context.Add(checkouHistory);
            context.SaveChanges();
        }

        private DateTime GetDefaultCheckoutTime(DateTime now)
        {
            return now.AddDays(30);
        }

        public bool IsCheckedOut(int assetId)
        {
            return context.Checkouts
                .Where(ch => ch.LibraryAsset.Id == assetId).Any();         
        }

        public string GetCurrentHoldPatronName(int holdId)
        {
            var hold = context.Holds
                .Include(a => a.LibraryAsset)
                .Include(a => a.LibraryCard)
                .FirstOrDefault(h => h.Id == holdId);

            //var cardId = hold.LibraryAsset.Id;

            //var patron = context.Patrons
            //    .Include(p => p.LibraryCard)
            //    .FirstOrDefault(p => p.LibraryCard.Id == cardId);
            var cardId = hold.LibraryCard.Id;
             

            var patron = context.Patrons
                .Include(p => p.LibraryCard)
               .First(p => p.LibraryCard.Id == cardId);

            return patron?.FirstName + " " + patron?.LastName;
        }

        public DateTime GetCurrentHoldPlaced(int holdId)
        {
            return context.Holds
                .Include(h => h.LibraryAsset)
                .Include(h => h.LibraryCard)
                .FirstOrDefault(h => h.Id == holdId)
                .HoldPlaced;
        }

        public void PlaceHold(int assetId, int libraryCardId)
        {
            var now = DateTime.Now;

            var asset = context.LibraryAssets
                .Include(a => a.Status)
                .First(a => a.Id == assetId);

            var card = context.LibraryCards
                .First(a => a.Id == libraryCardId);

            context.Update(asset);

            if (asset.Status.Name == "Available") 
            {
                asset.Status = context.Statuses.FirstOrDefault(a => a.Name == "On Hold");
            }

            var hold = new Hold
            {
                HoldPlaced = now,
                LibraryAsset = asset,
                LibraryCard = card
            };

            context.Add(hold);
            context.SaveChanges();

        }

        private void RemoveExistingCheckouts(int assetid)
        {
            //remove any existing checkouts     
            var checkout = context.Checkouts.FirstOrDefault(i => i.Id == assetid);
            if (checkout != null)
            {
                context.Remove(checkout);
            }
        }

        private void CloseExistingCheckoutHistory(int assetid, DateTime now)
        {
            //close any existing checkout history
            var history = context.CheckoutHistories
                .FirstOrDefault(h => h.Id == assetid && h.CheckedIn == null);
            if (history != null)
            {
                context.Update(history);
                history.CheckedIn = now;
            }
        }

        public string GetCurrentCheckoutPatron(int assetid)
        {
            var checkout = context.Checkouts
             .Include(co => co.LibraryAsset)
             .Include(co => co.LibraryCard)
             .FirstOrDefault(co => co.Id == assetid);  

            if (checkout == null)
            {
                return "Not checked out.";
            }

            var cardId = checkout.LibraryCard.Id;

            var patron = context.Patrons
             .Include(p => p.LibraryCard)
             .FirstOrDefault(p => p.LibraryCard.Id == cardId);

            return patron.FirstName + " " + patron.LastName;
        }

   
    }
}
