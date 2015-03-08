using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentInformation.VModel;
using StudentInformation.Models;
namespace StudentInformation.Controllers
{

    public class StudentController : Controller
    {
        StudentInfoDataContext dbContext = new StudentInfoDataContext();
        int Id = 2;
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        #region Insert Student
        
        public ActionResult InsertStudent()
        {
            StudentVModel vmodel = new StudentVModel();
            return View(vmodel);
        }

        //Insert Student
        [HttpPost]
        public ActionResult InsertStudent(StudentVModel vmodel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Id++;                           //Student Id Increment  
                    vmodel.Student.Id = Id;
                    dbContext.InsertStudent(vmodel.Student);
                    TempData["Message"] = "Insert Successfully";
                    return View(vmodel);
                }
                catch (Exception)
                {
                    TempData["Message"] = "Not Inserted";
                    
                }   
            }

            return View(vmodel);
        }

        #endregion

        //get student list
        public ActionResult GetAllStudent()
        {
            return View(dbContext.GetAllStudent());
        }

        //Get Student by Id 
        public ActionResult StudentGetById(int id = 0)
        {
            try
            {
                StudentInfo model = new StudentInfo();
                model = dbContext.StudentGetbyId(id);
                return View(model);
            }
            catch (Exception)
            {

                TempData["Message"] = "Data Not Exist";
            }
            
            return RedirectToAction("Index","Home");
        }

    }
}