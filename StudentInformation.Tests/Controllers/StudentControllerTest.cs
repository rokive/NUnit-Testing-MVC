using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentInformation.Controllers;
using StudentInformation.Models;
using StudentInformation.VModel;
using System.Web.Mvc;
using System.Collections.Generic;
namespace StudentInformation.Tests.Controllers
{
    [TestClass]
    public class StudentControllerTest
    {

        [TestMethod]
        
        public void StudentInsert()
        {
            //Arrange
            StudentVModel student = new StudentVModel();
            student.Student=new StudentInfo{Name="Rokive",FatherName="shah alam", Address = "H#1, Shimanto Shorok, Shonir Akhra, Jatrabari, Dhaka-1362",Class="0ne",Roll=2};
            //Act
            StudentController studentContr = new StudentController();
            var result = studentContr.InsertStudent(student) as ViewResult;
            var tempData = result.TempData["Message"];
            //Assert 
            Assert.AreEqual("Insert Successfully", tempData);
        }
        [TestMethod]
        public void StudentList()
        {
            //Arrange
            StudentVModel student = new StudentVModel();
            
            //Act
            StudentController studentContr = new StudentController();
            var result = studentContr.GetAllStudent() as ViewResult;
            var model=(List<StudentInfo>)result.Model;
            
            //Assert
            Assert.IsTrue(model.Count==2);
        }

        [TestMethod]
        public void GetStudentById()
        {
            
            //Act
            StudentController studentCtr = new StudentController();
            var result = (ViewResult)studentCtr.StudentGetById(1);
            var model=result.Model;

            //Assert
            Assert.IsNotNull(model);
        }

        [TestMethod]
        public void GetStudentByIdNotExist()
        {
            //Act
            StudentController studentCtr = new StudentController();
            var result = (ViewResult)studentCtr.StudentGetById(-1);
            var model = result.Model;

            //Assert
            Assert.IsNull(model);
        }
    }
}
