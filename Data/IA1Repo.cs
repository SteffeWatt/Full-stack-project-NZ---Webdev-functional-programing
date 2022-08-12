using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A1.Models;

namespace A1.Data
{

    public interface IA1Repo
    {
        //this method will get all products in the DB
        IEnumerable<Product> GetAllProducts();
        //this method will get product with matching id ( if there is one)
        Product GetProductById(int id);
        //this method will save the changes done to the Database
        void SaveDBChanges();

    }
}