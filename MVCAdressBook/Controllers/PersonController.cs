using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;
using MVCAdressBook.Models;

namespace MVCAdressBook.Controllers
{
    public class PersonController : Controller
    {
        public static List<PersonModels> AdressList = new List<PersonModels>()
        {
            new PersonModels
            {
                PersonAdress = "Muraregatan",
                PersonId = Guid.NewGuid(),
            PersonName = "Emil",
                PersonPhoneNumber = 0763087446 ,
                time = DateTime.Now
    }
            };


        // GET: Person
        public ActionResult Index()
        {
            return View(AdressList);
        }

        // GET: Person/Details/5
        public ActionResult Details(Guid id)
        {
            var d = AdressList.FirstOrDefault(x => x.PersonId == id);
            return View(d);
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(PersonModels person)
        {
            PersonModels personAdress = new PersonModels();
          
                personAdress.PersonId = Guid.NewGuid();
            personAdress.PersonName = person.PersonName;
            personAdress.PersonPhoneNumber = person.PersonPhoneNumber;
            personAdress.PersonAdress = person.PersonAdress;
            personAdress.time = DateTime.Now;
            AdressList.Add(personAdress);

          


              
         
            


            return RedirectToAction("Index");

        }

        // GET: Person/Edit/5
        public ActionResult Edit(Guid id)
        {
            var edit = AdressList.FirstOrDefault(x => x.PersonId == id);
            return View(edit);
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(PersonModels person)
        {
            AdressList.FirstOrDefault(x => x.PersonId == person.PersonId).PersonAdress = person.PersonAdress;

            AdressList.FirstOrDefault(x => x.PersonId == person.PersonId).PersonName = person.PersonName;

            AdressList.FirstOrDefault(x => x.PersonId == person.PersonId).PersonPhoneNumber = person.PersonPhoneNumber;

            AdressList.FirstOrDefault(x => x.PersonId == person.PersonId).time = DateTime.Now;






            return View();
           
        }





        public ActionResult Delete(Guid id)
        {
            var d = AdressList.FirstOrDefault(x => x.PersonId == id);
            AdressList.Remove(d);
            return RedirectToAction("Index", "Person");

        }


        // POST: Person/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
