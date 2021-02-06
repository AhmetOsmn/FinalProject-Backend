using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ProductDetailDto :IDto
    {
        //birkac tablonun joini olabilir fakat databasede tek basina bir tablo olmadigindan IEntity olarak alamayiz.
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public short UnitsInStock { get; set; }
    }
}
