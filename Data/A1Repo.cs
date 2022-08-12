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
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            Product product = this.DBContext.Products.FirstOrDefault(P => P.Id == id);
            return product;
        }



    }
}


