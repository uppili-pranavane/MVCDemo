using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class Employee
    {
        public int Id { get; set; }



        [Required(ErrorMessage = "Please enter the Employee's ACEID.")]
        [StringLength(7, ErrorMessage = "The Name must be less than {1} characters.")]
        [Display(Name = "ACEID *")]
        public string AceId { get; set; }


        [Required(ErrorMessage = "Please enter the Employee's Name.")]
        [StringLength(20, ErrorMessage = "The Name must be less than {1} characters.")]
        [Display(Name = "Name *")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Please enter the Employee's Email.")]
        [StringLength(40, ErrorMessage = "The Email must be less than {1} characters.")]
        [Display(Name = "Email *")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Please enter the Employee's Mobile Number.")]
        [StringLength(10, ErrorMessage = "The Mobile Number must be less than {1} characters dontn't include +91.")]
        [Display(Name = "Mobile Number *")]
        public string Mobile { get; set; }


        [Required(ErrorMessage = "Please enter the Employee's Stream.")]
        
        [Display(Name = "Stream *")]
        public string Steam { get; set; }
    }
}
