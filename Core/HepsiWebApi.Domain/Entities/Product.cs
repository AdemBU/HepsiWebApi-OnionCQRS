using HepsiWebApi.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiWebApi.Domain.Entities
{
    public class Product : EntityBase
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int BrandId { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public Brand Brand { get; set; }  // ürün markası
        public ICollection<Category> Categories { get; set; }  // bir ürünün birden fazla kategorisi olabilir
        //public required string ImagePath { get; set; }

    }
}
