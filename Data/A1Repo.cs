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
        //this method finds a product in our database were the string does match with or contains letters / parts of the string

        //Implement this method tomorrov
        public IEnumerable<Product> GetProductContainingName(String id)
        {
            
            
            IEnumerable<Product> products = from product in DBContext.Products
                                            where product.Name.ToLower().Contains(id.ToLower())
                                            select product;
            return products;
            // return product;
        }

        public Comment Writecomment(Comment comment)
        {
            DBContext.Add(comment);
            SaveDBChanges();
            return comment;
        }


        //this method saves the changes we do to the database
        public void SaveDBChanges()
        {

           // IEnumerable<Comment> comments = DBContext.Comments.ToList<Comment>(); use this line and add comments.
            
            DBContext.SaveChanges();
        }

        
    }
}


