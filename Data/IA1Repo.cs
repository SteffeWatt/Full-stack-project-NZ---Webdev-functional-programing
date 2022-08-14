using A1.Models;




namespace A1.Data
{

    public interface IA1Repo
    {
        //this method will get all products in the DB
        IEnumerable<Product> GetAllProducts();
        //this method will get product with matching id ( if there is one)
        IEnumerable<Product> GetProductContainingName(string id);
        //this method will save the changes done to the Database

        Comment Writecomment(Comment comment);

        IEnumerable<Comment> GetRecentComments();

        // IEnumerable<Product> GetProductPhoto(string id);
        void SaveDBChanges();

    }
}