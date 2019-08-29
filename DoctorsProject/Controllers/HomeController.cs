using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoctorsProject.Models;
using DoctorsProject.Services;

namespace DoctorsProject.Controllers
{
    public partial class HomeController : Controller
    {
        public virtual ActionResult Index()
        {
            var vm = DoctorsDetailService.DoctorsDetail();
            return View(vm);
        }

        public virtual ActionResult AddDoctor()
        {
            var vm = new AddDoctorViewModel { Id = Guid.Empty };
            return View(MVC.Home.Views.AddDoctor, vm);
        }

        public virtual ActionResult SaveDoctor(AddDoctorViewModel addDoctorViewModel)
        {
            if (ModelState.IsValid)
            {
                if (addDoctorViewModel.Id == Guid.Empty)
                {
                    addDoctorViewModel.Id = Guid.NewGuid();
                }

                var result = DoctorsDetailService.SaveDoctor(addDoctorViewModel);
                if (result)
                {
                    return RedirectToAction(MVC.Home.ActionNames.Index);

                }
                else
                {
                    ModelState.AddModelError("Error","Unexpected error");
                }
            }
            return View(MVC.Home.Views.AddDoctor, addDoctorViewModel);
        }

    }
}