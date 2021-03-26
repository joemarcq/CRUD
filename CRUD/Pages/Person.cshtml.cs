using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUD.Pages
{
    public class RegisterModel : PageModel
    {
        public RegisterModel(CRUDDBContext registercontext)
        {
            _cruddbcontext = registercontext;
        }


        private readonly CRUDDBContext _cruddbcontext;

        [BindProperty]
        public Person Person { get; set; }

        public List<Person> Persons = new List<Person>();
  

        public void OnGet()
        {
            Persons = _cruddbcontext.Persons.ToList();
        }

        public ActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                Persons = _cruddbcontext.Persons.ToList();
                return Page();
            }
            _cruddbcontext.Persons.Add(Person);
            _cruddbcontext.SaveChanges();
            

            return Redirect("/person");
        }

        public void OnGetDelete(int id)
        {
              var per = _cruddbcontext.Persons.FirstOrDefault(Person => Person.PersonId == id);

            if (per != null)
            {
                _cruddbcontext.Persons.Remove(per);
                _cruddbcontext.SaveChanges();
            }    

            OnGet();

        }
    }
}
