using Microsoft.EntityFrameworkCore;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        private readonly SignalRContext _context;
        public EfProductDal(SignalRContext context) : base(context)
        {
            _context = context;
        }

        public List<Product> GetProductsWithCategory()
        {
           return _context.Products.Include(p => p.Category).ToList();
        }

        public int ProductCount()
        {
            return _context.Products.Count();
        }

        public int ProductCountByCategoryNameDrink()
        {
            return _context.Products.Include(p => p.Category)
                .Where(p => p.CategoryID == (_context.Categories.Where
                (y => y.CategoryName == "İçecek").Select(z => z.CategoryID).FirstOrDefault())).Count();
        }

        public int ProductCountByCategoryNameHamburger()
        {
            return _context.Products.Include(p => p.Category)
                .Where(p => p.CategoryID == (_context.Categories.Where
                (y => y.CategoryName == "Hamburger").Select(z => z.CategoryID).FirstOrDefault())).Count();
        }

        public string ProductNameByMaxPrice()
        {
            return _context.Products.Where(p => p.Price == (_context.Products.Max(x => x.Price)))
                .Select(z=>z.ProductName).FirstOrDefault();
        }

        public string ProductNameByMinPrice()
        {
            return _context.Products.Where(p => p.Price == (_context.Products.Min(x => x.Price)))
               .Select(z => z.ProductName).FirstOrDefault();
        }

        public decimal ProductPriceAvg()
        {
            return _context.Products.Average(p => p.Price);
        }
    }
}
