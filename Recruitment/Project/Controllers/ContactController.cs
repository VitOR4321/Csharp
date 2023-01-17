using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Data;
using Project.Models;
using Project.Models.Domain;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

namespace Project.Controllers
{
    public class ContactController : Controller
    {
        private readonly Context context;
        public ContactController(Context context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var contacts = await context.Contacts.ToListAsync(); 
            return View(contacts);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Add(AddContactViewModel addContactRequest) {
            var contact = new Contact()
            {
                id = Guid.NewGuid(),
                firstName = addContactRequest.firstName,
                lastName = addContactRequest.lastName,
                email = addContactRequest.email,
                password= addContactRequest.password,
                category = addContactRequest.category,
                subcategory = addContactRequest.subcategory,
                phone = addContactRequest.phone,
                birthdate= addContactRequest.birthdate,

            };

            await context.Contacts.AddAsync(contact);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> View(Guid id)
        {
            var contact = await context.Contacts.FirstOrDefaultAsync(x => x.id == id);
            
            if(contact != null)
            {
                var viewModel = new UpdateContactViewModel()
                {
                    id = contact.id,
                    firstName = contact.firstName,
                    lastName = contact.lastName,
                    email = contact.email,
                    password = contact.password,
                    category = contact.category,
                    subcategory = contact.subcategory,
                    phone = contact.phone,
                    birthdate = contact.birthdate,
                };

                return await Task.Run(()=>View("View", viewModel));
            }
            return RedirectToAction("Index");
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(UpdateContactViewModel model)
        {
            var contact = await context.Contacts.FindAsync(model.id);
            if(contact != null) 
            { 
                contact.firstName= model.firstName;
                contact.lastName= model.lastName;
                contact.email= model.email;
                contact.password= model.password;
                contact.category= model.category;
                contact.subcategory= model.subcategory;
                contact.phone= model.phone;
                contact.birthdate= model.birthdate;

                await context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Delete(UpdateContactViewModel model)
        {
            var contact = await context.Contacts.FindAsync(model.id);

            if(contact != null)
            {
                context.Contacts.Remove(contact);
                await context.SaveChangesAsync();
            
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index");
        }
    }
}
