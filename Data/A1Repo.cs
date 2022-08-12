using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using A1.Models;

namespace A1.Data
{


    public class A1Repo : IA1Repo
    {

        private readonly A1DBContext DBContext;

        public A1Repo(A1DBContext DBContext)
        {
            this.DBContext = DBContext;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            IEnumerable<Product> products = DBContext.Products.ToList<Product>();
            return products;
        }
        //this method finds a product in our database with a matching id
        public Product GetProductById(String id)
        {
            Product product = DBContext.Products.FirstOrDefault(P => P.Id == id);
            return product;
        }

        //this method saves the changes we do to the database
        public void SaveDBChanges()
        {
            DBContext.SaveChanges();
        }



    }
}


