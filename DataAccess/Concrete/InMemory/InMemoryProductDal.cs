using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> { 
                new Product{ProductId=1, CategoryId=1, ProductName = "Bardak", UnitPrice = 15, UnitsInStock = 15},
                new Product{ProductId=2, CategoryId=1, ProductName = "Kamera", UnitPrice = 500, UnitsInStock = 3},
                new Product{ProductId=3, CategoryId=2, ProductName = "Telefon", UnitPrice = 1500, UnitsInStock = 2},
                new Product{ProductId=4, CategoryId=2, ProductName = "Klavye", UnitPrice = 150, UnitsInStock = 65},
                new Product{ProductId=5, CategoryId=2, ProductName = "Fare", UnitPrice = 85, UnitsInStock = 1},
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
            Console.WriteLine(product.ProductName + " basari ile eklendi");
        }

        public void Delete(Product product)
        {
            //LINQ - Language Integrated Query        
            // '=>' : Lambda

            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId); //_products icerisindeki her p icin, p.ıd'si benim aradigim productun id'sine esit ise o p nin referansini tutuyoruz.
            _products.Remove(productToDelete);  //silme islemi icin referansina ulasmamiz gerekiyor.
        }
        public void Update(Product product)
        {
            //Gonderdigim urun id'sine sahip olan listedeki urunu bul demek.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId); //guncellenecek referansi bulmamiz lazim.
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p=>p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
