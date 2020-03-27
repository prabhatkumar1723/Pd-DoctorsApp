using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoctorsProject.Models
{
    public class AddDoctorViewModel
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public int YearOfExperience { get; set; }

        public string Treatments { get; set; }

        public int BaseCharge { get; set; }

        public string Designation { get; set; }

        public string Qualification { get; set; }
    }
}