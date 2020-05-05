using LibraryData;
using LibraryData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryServices
{
    public class PatronService : IPatron
    {
        private readonly LibraryDbContext context;

        public PatronService(LibraryDbContext context)
        {
            this.context = context;
        }
        public void Add(Patron newPatron)
        {
            context.Add(newPatron);
            context.SaveChanges();
        }

        public Patron Get(int id)
        {
            return context.Patrons
                .Include(p => p.LibraryCard)
                .Include(p => p.HomeLibraryBranch)
                .FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Patron> GetAll()
        {
            return context.Patrons
               .Include(p => p.LibraryCard)
               .Include(p => p.HomeLibraryBranch);
        }

        public IEnumerable<CheckoutHistory> GetCheckoutHistory(int patronId)
        {
            //var cardId = context.Patrons
            //    .Include(p => p.LibraryCard)
            //    .FirstOrDefault(p => p.Id == patronId)
            //    .LibraryCard.Id;

            var cardId = Get(patronId).LibraryCard.Id;

            return context.CheckoutHistories
                .Include(p => p.LibraryCard)
                .Include(p => p.LibraryAsset)
                .Where(p => p.Id == patronId)
                .OrderByDescending(c => c.CheckedOut);
        }

        public IEnumerable<Checkout> GetCheckouts(int patronId)
        {
            var cardId = Get(patronId).LibraryCard.Id;

            return context.Checkouts
                 .Include(p => p.LibraryCard)
                 .Include(p => p.LibraryAsset)
                 .Where(p => p.Id == patronId);
           
        }

        public IEnumerable<Hold> GetHolds(int patronId)
        {
            var cardId = Get(patronId).LibraryCard.Id;

            return context.Holds
               .Include(p => p.LibraryCard)
               .Include(p => p.LibraryAsset)
               .Where(p => p.Id == patronId)
               .OrderByDescending(c => c.HoldPlaced);
        }
    }
}
