namespace ShoppringCart_MVC.Models.Entities
{
    public class User
    {
        public int UserId { get; set; } // user_id
        public string FullName { get; set; } // fullname
        public string Role { get; set; } // ENUM(Customer, Staff, Admin)
        public DateTime Dob { get; set; } // dob
        public string Email { get; set; } // email
        public string Phone { get; set; } // phone
        public string Avatar { get; set; } // avatar
        public bool IsApproved { get; set; } // is_approved
        public DateTime CreatedAt { get; set; } // created_at
    }
}
