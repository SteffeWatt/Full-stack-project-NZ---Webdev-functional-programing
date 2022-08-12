using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A1.Models
{
    //our class that represents a product in our database / application
    public class Product
    {
        [Key]
        public string Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Price { get; set; }

    }
}