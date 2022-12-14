using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        [Key]
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public double UnitPrice { get; set; }
        public string Status { get; set; } = "Sıfır";//kullanılmış, sıfır, az kullanılmış gibi
        public bool IsOfferable { get; set; } = false;
        public bool IsSold { get; set; } = false;
        public string Description { get; set; }
        public int ColorId { get; set; }
        public int SellerId { get; set; }
        public int BrandId { get; set; }
    }
}
