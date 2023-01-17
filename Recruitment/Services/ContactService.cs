using ContactsListApp.Models;

namespace DisplayApp.Services
{
    public class ContactService : IContactService
    {
        private readonly HttpClient httpClient;

        public ContactService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        // wyświetlenie listy kontaktów
        public async Task<List<Contact>> GetContacts()
        {
            return await httpClient.GetFromJsonAsync<List<Contact>>("api/Contacts/GetContacts");
        }
        // wyświetlenie danych jednego kontaktu
        public async Task<Contact> GetContact(Guid id)
        {
            return await httpClient.GetFromJsonAsync<Contact>("api/Contacts/GetContact/"+id);
        }
        // dodanie nowego kontaktu
        public async Task<AddContactRequest> AddContact()
        {
            return await httpClient.GetFromJsonAsync<AddContactRequest>("api/Contacts/AddContact");
        }
        // edycja kontaktu
        public async Task<UpdateContactRequest> EditContact(Guid id)
        {
            return await httpClient.GetFromJsonAsync<UpdateContactRequest>("api/Contacts/EditContact/" + id);
        }
        // usunięcie kontaktu
        public async Task<Contact> DeleteContact(Guid id)
        {
            return await httpClient.GetFromJsonAsync<Contact>("api/Contacts/DeleteContact/" + id);
        }

       
    }
}
