using ContactsListApp.Models;

namespace DisplayApp.Services
{
    public interface IContactService
    {
        Task<List<Contact>> GetContacts();

        Task<Contact> GetContact(Guid id);

        Task<Contact> DeleteContact(Guid id);

        Task<UpdateContactRequest> EditContact(Guid id);

        Task<AddContactRequest> AddContact();
    }
}
