using LibraryData;
using LibraryData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryServices
{
    public class LibraryAssetService : ILibraryAsset
    {
        private readonly LibraryDbContext context;

        public LibraryAssetService(LibraryDbContext context)
        {
            this.context = context;
        }
        public void Add(LibraryAsset newAsset)
        {
            context.Add(newAsset);
            context.SaveChanges();
        }

        public IEnumerable<LibraryAsset> GetAll()
        {
            return context.LibraryAssets
                .Include(asset => asset.Status)
                .Include(asset=>asset.Location);
        }


        public LibraryAsset GetById(int id)
        {
            return GetAll().
                FirstOrDefault(assetId => assetId.Id == id);
         
        }

        public string GetDeweyIndex(int id)
        {
            if (context.Books.Any(book=> book.Id==id))
            {
                return context.Books.FirstOrDefault(book => book.Id == id).DeweyIndex;
            }
            else
            {
                return "";
            }
        }

        public string GetIsbn(int id)
        {
            if (context.Books.Any(book => book.Id == id))
            {
                return context.Books.FirstOrDefault(book => book.Id == id).ISBN;
            }
            else
            {
                return "";
            }
        }

        public LibraryBranch GetLocation(int id)
        {
            return GetById(id).Location;
        }

        public string GetTitle(int id)
        {
            return context.LibraryAssets
                .FirstOrDefault(asset => asset.Id == id).Title;
        }

        public string GetType(int id)
        {
            var book = context.LibraryAssets.OfType<Book>()
                .Where(b => b.Id == id);
            return book.Any() ? "Book" : "Video";
        }

        public string GetAuthorOrDirector(int id)
        {
            var isBook = context.LibraryAssets.OfType<Book>()
                .Where(asset => asset.Id == id).Any();
            var isVideo = context.LibraryAssets.OfType<Video>()
             .Where(asset => asset.Id == id).Any();

            return isBook ?
                context.Books.FirstOrDefault(asset => asset.Id == id).Author :
                 context.Videos.FirstOrDefault(asset => asset.Id == id).Director ??
                 "Not found";

        }
    }
}
