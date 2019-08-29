using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoctorsProject.DoctorsDA;
using DoctorsProject.Models;

namespace DoctorsProject.Services
{
    public class DoctorsDetailService
    {
        public static DoctorDetailsViewModel DoctorsDetail()
        {
            var details = DoctorsDetailDA.Details();
            var vm = new DoctorDetailsViewModel
            {
                DoctorDetailsItemViewModel = new List<DoctorDetailsItemViewModel>()
            };
            foreach(var item in details)
            {
                vm.DoctorDetailsItemViewModel.Add(new DoctorDetailsItemViewModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    Address = item.Address,
                    PhoneNumber = item.PhoneNumber
                });
            }
            return vm;
        }

        public static bool SaveDoctor(AddDoctorViewModel vm)
        {
            var result = false;
            var recordId  = DoctorsDetailDA.SaveDoctor(vm);
            if (recordId != Guid.Empty)
                result = true;

            return result;
        }

    }
}