using BigSchool_ThWeb.Models;
using BigSchool_ThWeb.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigSchool_ThWeb.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [Authorize]
      
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
               
                Categories = _dbContext.Categories.ToList()
               
            };
           
            return View(viewModel);
        }
    }
}