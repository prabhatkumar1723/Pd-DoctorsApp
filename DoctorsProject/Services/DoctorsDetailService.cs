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
        public static DoctorDetailsViewModel GetDoctorsList()
        {
            var details = DoctorsDetailDA.GetDoctorsList();
            var vm = new DoctorDetailsViewModel
            {
                DoctorDetailsItemViewModelList = new List<DoctorDetailsItemViewModel>()
            };
            foreach(var item in details)
            {
                vm.DoctorDetailsItemViewModelList.Add(new DoctorDetailsItemViewModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    Address = item.Address,
                    PhoneNumber = item.PhoneNumber,
                    Age = item.Age,
                    BaseCharge = item.BaseCharge,
                    Designation = item.Designation,
                    Email = item.Email,
                    Gender = item.Gender,
                    Qualification = item.Qualification,
                    Treatments = item.Treatments,
                    YearOfExperience = item.YearOfExperience
                });
            }
            return vm;
        }

        public static DoctorDetailsItemViewModel GetDoctorProfile(Guid id)
        {
            var dto = DoctorsDetailDA.GetDoctorProfile(id);

            return DoctorDetailsItemViewModel.CreateDetailsItemViewModel(dto);

        }

        public static bool SaveDoctorBasicInfo(AddDoctorViewModel vm)
        {
            var result = false;
            var recordId  = DoctorsDetailDA.SaveDoctorBasicInfo(vm);
            if (recordId != Guid.Empty)
                result = true;

            return result;
        }

    }
}