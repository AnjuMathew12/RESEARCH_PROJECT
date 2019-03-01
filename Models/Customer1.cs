using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MVCDatabaseApp.Models
{
    public class Customer1
    {
        public int Customer1Id { get; set; }
        [Required(ErrorMessage = "Can't be empty")]
        [Display(Name = "Customer Name")]
        //[RegularExpression()]

        public string name { get; set; }

        [Required(ErrorMessage = "Can't be empty")]
        [Display(Name = "Customer Address")]
        //[RegularExpression()]
           
        public string address { get; set; }
        [Required(ErrorMessage = "Can't be empty")]
        [Display(Name = "Email")]
        //[RegularExpression()]

        public string email { get; set; }

        [Required(ErrorMessage = "Can't be empty")]
        [Display(Name = "Username")]
        //[RegularExpression()]

        public string username { get; set; }
        [Required(ErrorMessage = "Can't be empty")]
        [Display(Name = "Password")]
        //[RegularExpression()]

        public string pwd { get; set; }
    }
}