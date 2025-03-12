namespace ShoppringCart_MVC.Models.Entities
{
    public class Cart
    {
        public int CartId { get; set; } // cart_id
        public int UserId { get; set; } // user_id
        public DateTime CreatedAt { get; set; } // created_at
    }
}
