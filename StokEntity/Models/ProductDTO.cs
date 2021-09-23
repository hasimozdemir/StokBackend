using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StokEntity.Models
{
    public class ProductDTO
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stok { get; set; }
        public int Fiyat { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
       
    }
}
