using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoctorsProject.DoctorsDtos;

namespace DoctorsProject.Models
{
    public class DoctorDetailsItemViewModel
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

        public static DoctorDetailsItemViewModel CreateDetailsItemViewModel(DoctorsDetailDto dto)
        {
            if (dto != null)
            {
                return new DoctorDetailsItemViewModel()
                {
                    Id = dto.Id,
                    Name = dto.Name,
                    Address = dto.Address,
                    PhoneNumber = dto.PhoneNumber,
                    Age = dto.Age,
                    BaseCharge = dto.BaseCharge,
                    Designation = dto.Designation,
                    Email = dto.Email,
                    Gender = dto.Gender,
                    Qualification = dto.Qualification,
                    Treatments = dto.Treatments,
                    YearOfExperience = dto.YearOfExperience,
                };
            }
            else
            {
                return null;
            }
        }
    }
}