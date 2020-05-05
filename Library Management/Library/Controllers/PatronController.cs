using Library.ViewModels.Patron;
using LibraryData;
using LibraryData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Library.Controllers
{
    public class PatronController : Controller
    {
        private readonly IPatron _patron;
        public PatronController(IPatron patron)
        {
            this._patron = patron;
        }

        public IActionResult Index()
        {
            var allPatrons = _patron.GetAll();

            var model = new List<PatronDetailModel>();

            foreach (var item in allPatrons)
            {
                var modeltoadd = new PatronDetailModel
                {
                    Id = item.Id,
                    LastName = item.FirstName ?? "no first name provided",
                    FirstName = item.LastName ?? "no last name provided",
                    LibraryCardId = item.LibraryCard.Id,
                    OverdueFees = item.LibraryCard.Fees,
                    HomeLibraryBranch = item.HomeLibraryBranch?.Name
                };

                model.Add(modeltoadd);

            }

            //var patronModels = allPatrons
            //    .Select(p => new PatronDetailModel
            //    {
            //        Id = p.Id,
            //        LastName = p.LastName ?? "No First Name Provided",
            //        FirstName = p.FirstName ?? "No Last Name Provided",
            //        LibraryCardId = p.LibraryCard.Id,
            //        OverdueFees = p.LibraryCard.Fees,
            //        HomeLibraryBranch = p.HomeLibraryBranch?.Name
            //    }).ToList();

            //var model = new PatronIndexModel
            //{
            //    Patrons = patronModels
            //};

            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var patronToGet = _patron.Get(id);

            var model = new PatronDetailModel
            {
                Id = patronToGet.Id,
                LastName = patronToGet.LastName,
                FirstName = patronToGet.FirstName,
                Address = patronToGet.Address,
                HomeLibraryBranch = patronToGet.HomeLibraryBranch.Name,
                MemberSince = patronToGet.LibraryCard.Created,
                OverdueFees = patronToGet.LibraryCard.Fees,
                LibraryCardId = patronToGet.LibraryCard.Id,
                Telephone = patronToGet.TelephoneNumber,
                AssetsCheckedOut = _patron.GetCheckouts(id) ?? new List<Checkout>(),
                CheckoutHistory = _patron.GetCheckoutHistory(id),
                Holds = _patron.GetHolds(id)
            };

            return View(model);
        }


    }
}
