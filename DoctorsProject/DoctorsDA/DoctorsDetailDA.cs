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
        public static List<DoctorsDetailDto> Details()
        {
            using(var db = new  DataClassesDataContext() )
            {
                var details = (from d in db.DoctorDetails
                               select new DoctorsDetailDto()
                               {
                                   Id = d.Id,
                                   Name = d.DName,
                                   Address = d.DAddress,
                                   PhoneNumber = d.PhoneNumber
                               }).ToList();

                return details;
            }
        }

        public static Guid SaveDoctor(AddDoctorViewModel vm)
        {
            using (var db = new DataClassesDataContext())
            {
                
                    var record = new DoctorDetail()
                    {
                        Id = vm.Id,
                        DName = vm.Name,
                        DAddress = vm.Address,
                        PhoneNumber = vm.PhoneNumber
                    };

                    db.DoctorDetails.InsertOnSubmit(record);
                    db.SubmitChanges();

                return record.Id;
            }
        }
    }
}