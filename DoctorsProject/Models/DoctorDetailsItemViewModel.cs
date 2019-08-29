using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorsProject.Models
{
    public class DoctorDetailsItemViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }
    }
}