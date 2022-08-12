using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A1.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Price { get; set; }

        public Product(int id, String ProductName, String ProductDescription, String ProductPrice)
        {
            this.Id = id;
            this.Name = ProductName;
            this.Description = ProductDescription;
            this.Price = ProductPrice;

        }
    }
}