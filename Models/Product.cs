using System.ComponentModel.DataAnnotations;

public class Product {
    [Key]
    private String? id { get; set; }
    private String? name { get; set; }
    private String? description { get; set; }
    private String? price { get; set; }

    public Product(String id, String ProductName, String ProductDescription, String ProductPrice)
    {
        this.id = id;

    }


}