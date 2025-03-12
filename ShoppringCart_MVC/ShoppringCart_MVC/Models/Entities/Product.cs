namespace ShoppringCart_MVC.Models.Entities
{
    public class Product
    {
        public int ProductId { get; set; } // product_id
        public string Name { get; set; } // name
        public string Description { get; set; } // description
        public decimal Price { get; set; } // price
        public string Stock { get; set; } // stock
        public string Image { get; set; } // image
        public int CategoryId { get; set; } // category_id
        public DateTime UpdatedAt { get; set; } // updated_at
    }
}
