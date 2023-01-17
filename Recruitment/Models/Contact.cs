using System.ComponentModel.DataAnnotations;
// klasa obiektu z atrybutami na którym chcęmy wykonywać operacje
namespace ContactsListApp.Models
{
    public class Contact
    {
        public static Contact SingleOrDefault;
        [Required]
        public Guid id { get; set; }
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        [Key]
        public string email { get; set; }
        [Required]
        [RegularExpression(@"^(?=[^a - z] *[a - z])(?=[^A - Z] *[A - Z])(?=\D *\d)(?=[^!#%$]*[!#%$])[A-Za-z0-9!#%]{8,32}$")]
        public string password { get; set; }
        [Required]
        public string category { get; set; }
        public string subcategory { get; set; }
        [Required]
        [RegularExpression(@"\d{9}")]
        public long phone { get; set; }
        [Required]
        public string birthdate { get; set; }
    }
}
