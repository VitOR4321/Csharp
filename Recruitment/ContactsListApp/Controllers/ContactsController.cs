using ContactsListApp.Data;
using ContactsListApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
// kontroler naszej aplikacji, gdzie definiowane są requesty i operacje Api
namespace ContactsListApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController : Controller
    {
        private readonly ContactApiDbContext dbContext;
        public ContactsController(ContactApiDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        // Request dla wyświetlenia całej listy w bazie
        [Route("GetContacts")]
        public async Task<IActionResult> GetContacts()
        {
            return Ok(await dbContext.Contacts.ToListAsync());
        }
        // Request dla wyświetlenia jednego rekordu o podanym id
        [HttpGet]
        [Route("GetContact/{id:guid}")]
        public async Task<IActionResult> GetSingleContact([FromRoute] Guid id)
        {
            var contact = await dbContext.Contacts.FindAsync(id);

            if(contact == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(contact);
            }
        }
        // kontroler naszej aplikacji, do dodawania rekordu do bazy
        [HttpPost]
        [Route("AddContact")]
        public async Task<IActionResult> AddContact(AddContactRequest addContactRequest)
        {
            var contact = new Contact()
            {
                id = Guid.NewGuid(),
                firstName = addContactRequest.firstName,
                lastName = addContactRequest.lastName,
                email = addContactRequest.email,
                password = addContactRequest.password,
                category= addContactRequest.category,
                subcategory = addContactRequest.subcategory,
                phone = addContactRequest.phone,
                birthdate = addContactRequest.birthdate,
            };

            await dbContext.Contacts.AddAsync(contact);
            await dbContext.SaveChangesAsync();

            return Ok(contact);
        }
        // kontroler naszej aplikacji, edytujemy konkretny rekord podając id
        [HttpPut]
        [Route("EditContact/{id:guid}")]
        public async Task<IActionResult> UpdateContact([FromRoute] Guid id, UpdateContactRequest updateContactRequest)
        {
            var contact = await dbContext.Contacts.FindAsync(id);
            if(contact != null)
            {
                contact.firstName = updateContactRequest.firstName;
                contact.lastName = updateContactRequest.lastName;
                contact.email = updateContactRequest.email;
                contact.category = updateContactRequest.category;
                contact.subcategory = updateContactRequest.subcategory;
                contact.phone = updateContactRequest.phone;
                contact.birthdate = updateContactRequest.birthdate;

                await dbContext.SaveChangesAsync();
                return Ok(contact) ;
            }
            else
            {
                return NotFound();
            }
            
        }
        // kontroler naszej aplikacji, gdzie usuwamy rekord podając jego id
        [HttpDelete]
        [Route("DeleteContact/{id:guid}")]
        public async Task<IActionResult> DeleteContact([FromRoute] Guid id)
        {
            var contact = await dbContext.Contacts.FindAsync(id);
            if(contact != null)
            {
                dbContext.Remove(contact);
                await dbContext.SaveChangesAsync();
                return Ok(contact);
            }
            else
            {
                return NotFound();  
            }
        }
    }
}
