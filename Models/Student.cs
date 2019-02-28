using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MyProject.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Can't be empty")]
        [Display(Name = "Student Name")]
        //[RegularExpression()]

        public string Sname { get; set; }

        [Required(ErrorMessage = "Can't be empty")]
        [Display(Name = "Student address")]
        [DataType(DataType.MultilineText)]
        public string Saddress { get; set; }


        [Required(ErrorMessage = "Can't be empty")]
        [Display(Name = "Email address")]
        [DataType(DataType.EmailAddress)]
        public string Semail { get; set; }

        public Gender Sgender { get; set; }
    }
        public enum Gender
        {
            Male,
            Female
        }




    }
    