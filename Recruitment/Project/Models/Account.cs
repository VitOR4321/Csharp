namespace Project.Models
{
    public class Account
    {
        public string email { get; set; }
        public string password { get; set; }

        public bool keepLoggedIn { get; set; }
    }
}
