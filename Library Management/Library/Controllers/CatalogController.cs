using Library.ViewModels.Catalog;
using Library.ViewModels.CheckoutModels;
using LibraryData;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{
    public class CatalogController : Controller
    {
        private readonly ILibraryAsset assets;
        private readonly ICheckout checkouts;

        public CatalogController(ILibraryAsset assets, ICheckout checkouts)
        {
            this.assets = assets;
            this.checkouts = checkouts;
        }

        public IActionResult Index()
        {
            var assetModels = assets.GetAll();

            var model = new List<AssetIndexListingModel>();

            foreach (var item in assetModels)
            {
                var modelToAdd = new AssetIndexListingModel
                {
                    Id = item.Id,
                    ImageUrl = item.ImageUrl,
                    AuthorOrDirector = assets.GetAuthorOrDirector(item.Id),
                    DeweyCallNumber = assets.GetDeweyIndex(item.Id),
                    Title = item.Title,
                    Type = assets.GetType(item.Id)
                };

                model.Add(modelToAdd);

            }

            //var listingResult = assetModels
            //    .Select(result => new AssetIndexListingModel
            //    {
            //        Id = result.Id,
            //        ImageUrl = result.ImageUrl,
            //        AuthorOrDirector = assets.GetAuthorOrDirector(result.Id),
            //        DeweyCallNumber = assets.GetDeweyIndex(result.Id),
            //        Title = result.Title,
            //        Type = assets.GetType(result.Id)

            //    });

            //var model = new AssetIndexModel()
            //{
            //    Assets = listingResult
            //};

            return View(model);

        }

        public IActionResult Detail(int id)
        {
            var asset = assets.GetById(id);

            var currentHolds = checkouts.GetCurrentHolds(id)
                .Select(a => new AssetHoldModel
            {
                HoldPlaced = checkouts.GetCurrentHoldPlaced(a.Id).ToString(),
                PatronName = checkouts.GetCurrentHoldPatronName(a.Id)
            });
            var model = new AssetDetailModel
            {
                AssetId = id,
                Title = asset.Title,
                Type = assets.GetType(id),
                Year = asset.Year,
                Cost = asset.Cost,
                Status = asset.Status.Name,
                ImageUrl = asset.ImageUrl,
                AuthorOrDirector = assets.GetAuthorOrDirector(id),
                CurrentLocation = assets.GetLocation(id).Name,
                Dewey = assets.GetDeweyIndex(id),
                CheckoutHistory = checkouts.GetCheckoutHistory(id),
                ISBN = assets.GetIsbn(id),
                LatestCheckout = checkouts.GetLatestCheckout(id),
                PatronName = checkouts.GetCurrentCheckoutPatron(id),
                CurrentHolds = currentHolds
            };

            return View(model);

        }

        public IActionResult CheckIn(int id)
        {
            checkouts.CheckInItem(id);
            return RedirectToAction("Detail", new { id });
        }
        public IActionResult Checkout(int id)
        {
            var asset = assets.GetById(id);

            var model = new CheckoutModel
            {
                AssetId = id,
                ImageUrl = asset.ImageUrl,
                Title = asset.Title,
                LibraryCardId = "",
                IsCheckedOut = checkouts.IsCheckedOut(id)
            };
            return View(model);
        }

        public IActionResult Hold(int id)
        {
            var asset = assets.GetById(id);

            var model = new CheckoutModel
            {
                AssetId = id,
                ImageUrl = asset.ImageUrl,
                Title = asset.Title,
                LibraryCardId = "",
                IsCheckedOut = checkouts.IsCheckedOut(id),
                HoldCount = checkouts.GetCurrentHolds(id).Count()
            };
            return View(model);
        }
        public IActionResult MarkLost(int assetId)
        {
            checkouts.MarkLost(assetId);
            return RedirectToAction("Detail", new { assetId });
        }

        public IActionResult MarkFound(int assetId)
        {
            checkouts.MarkFound(assetId);
            return RedirectToAction("Detail", new { assetId });
        }

        [HttpPost]
        public IActionResult PlaceCheckout(int assetId, int libraryCardId)
        {
            checkouts.CheckoutItem(assetId, libraryCardId);
            return RedirectToAction("Detail", new { id = assetId });
        }


        [HttpPost]
        public IActionResult PlaceHold(int assetId, int libraryCardId)
        {
            checkouts.PlaceHold(assetId, libraryCardId);
            return RedirectToAction("Detail", new { id = assetId });
        }

    }
}
