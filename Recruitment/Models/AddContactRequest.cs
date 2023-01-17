namespace ContactsListApp.Models
{// klasa obiektu z atrybutami na którym chcęmy wykonywać operacje dodawania. Nie zawiera id
    public class AddContactRequest
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string category { get; set; }
        public string subcategory { get; set; }
        public long phone { get; set; }
        public string birthdate { get; set; }
    }
}
