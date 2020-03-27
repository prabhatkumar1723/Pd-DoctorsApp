using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorsProject.DoctorsDtos
{
    public class DoctorsDetailDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

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