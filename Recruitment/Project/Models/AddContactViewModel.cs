namespace Project.Models
{
    public class AddContactViewModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string category { get; set; }
        public string subcategory { get; set; }
        public long phone { get; set; }
        public DateTime birthdate { get; set; }
    }
}
