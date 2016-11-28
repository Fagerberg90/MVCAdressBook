using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace MVCAdressBook.Models
{
    public class PersonModels
    {
        public Guid PersonId  { get; set; }
        [Display(Name = "Firstname:")]
        public string PersonName  { get; set; }
        [Display(Name = "Phone number:")]
        public int PersonPhoneNumber { get; set; }
        [Display(Name = "Adress:")]
        public string PersonAdress { get; set; }
        [Display(Name = "Registred:")]
        public DateTime time { get; set; }
    }
}