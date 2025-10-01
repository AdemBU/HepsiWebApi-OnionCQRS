using HepsiWebApi.Domain.Common;
using HepsiWebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiWebApi.Domain.Entities
{
    public class Category : EntityBase
    {
        public Category()
        {

        }
        public Category(int parentId, string name, int priorty)
        {
            ParentId = parentId;
            Name = name;
            Priorty = priorty;
        }
        public required int ParentId { get; set; }  //kategoriler arası alt ve üst kategorileri oluşturmak için
        public required string Name { get; set; }
        public required int Priorty { get; set; }  // sıralama değeri
        public ICollection<Detail> Details { get; set; }  // bir kategorinin birden çok detayı olabilir
        public ICollection<Product> Products { get; set; } // bir kategoride birden çok product olabilir
    }
}
