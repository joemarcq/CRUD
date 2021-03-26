using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUD.Pages
{
    public class EditModel : PageModel
    {
        public EditModel(CRUDDBContext cruddbcontext)
        {
            _cruddbcontext = cruddbcontext;
        }

        private readonly CRUDDBContext _cruddbcontext;

        [BindProperty]
        public Person Person { get; set;}
        public void OnGet(int id)
        {
            Person = _cruddbcontext.Persons.FirstOrDefault(p => p.PersonId == id);
        }

        public ActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            //var per = _cruddbcontext.Persons.FirstOrDefault(person => person.PersonId==person.PersonId);

            Person per = new Person();
            per = _cruddbcontext.Persons.FirstOrDefault(p => p.PersonId == p.PersonId);

            if (per != null)
            {
                per.Firstname = Person.Firstname;
                per.Lastname = Person.Lastname;
                per.MI = Person.MI;
                per.EmailAddress = Person.EmailAddress;
                per.Address = Person.Address;
                per.Age = Person.Age;
                per.Contact = Person.Contact;

                _cruddbcontext.Update(per);
                _cruddbcontext.SaveChanges();
            }
            return Redirect("person");
        }

    }
}
