using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        //Product'u kullanabilmek icin, DataAccess projesine referans ekle dedik ve Entities projesini referans olarak ekledik.
        //Referansi ekledikten sonra using kismini ekledik.

        //Interface metotlari default publictir.
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        List<Product> GetAllByCategory(int categoryId);

    }
}
