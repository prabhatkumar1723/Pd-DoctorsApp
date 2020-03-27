using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoctorsProject.DoctorsDtos;
using DoctorsProject.Models;

namespace DoctorsProject.DoctorsDA
{
    public class DoctorsDetailDA
    {
        public static List<DoctorsDetailDto> GetDoctorsList()
        {
            using (var db = new DataClassesDataContext())
            {
                var details = (from d in db.DoctorDetails
                               select new DoctorsDetailDto()
                               {
                                   Id = d.Id,
                                   Name = d.DName,
                                   Address = d.DAddress,
                                   PhoneNumber = d.PhoneNumber,
                                   Age = d.Age.GetValueOrDefault(),
                                   Email = d.Email,
                                   BaseCharge = d.BaseCharge.GetValueOrDefault(),
                                   Designation = d.Designation,
                                   Gender = d.Gender,
                                   Qualification = d.Qualifications,
                                   Treatments = d.Treatments,
                                   YearOfExperience = d.YearOfExperience.GetValueOrDefault()
                               }).ToList();

                return details;
            }
        }

        public static DoctorsDetailDto GetDoctorProfile(Guid id)
        {
            var detail = GetDoctorsList().Single(z => z.Id == id);
            return detail;
        }

        public static Guid SaveDoctorBasicInfo(AddDoctorViewModel vm)
        {
            using (var db = new DataClassesDataContext())
            {
                var record = db.DoctorDetails.SingleOrDefault(p => p.Id == vm.Id);

                record.Id = record != null ? Guid.NewGuid() : vm.Id;
                record.DName = vm.Name;
                record.DAddress = vm.Address;
                record.PhoneNumber = vm.PhoneNumber;
                record.Age = vm.Age;
                record.Email = vm.Email;
                record.BaseCharge = vm.BaseCharge;
                record.Designation = vm.Designation;
                record.Gender = vm.Gender;
                record.Qualifications = vm.Qualification;
                record.Treatments = vm.Treatments;
                record.YearOfExperience = vm.YearOfExperience;

                db.DoctorDetails.InsertOnSubmit(record);
                db.SubmitChanges();

                return record.Id;
            }
        }
    }
}