using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A1.Models;

namespace A1.Data
{

    public interface IA1Repo
    {

        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);

    }
}