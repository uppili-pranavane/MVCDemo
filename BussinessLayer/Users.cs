using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class Users
    {
        [Required(ErrorMessage="Please enter your Name", AllowEmptyStrings =false)]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Please enter your User Name", AllowEmptyStrings = false)]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please enter your Password", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Password { get; set; }
       
    }
}