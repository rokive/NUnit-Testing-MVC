using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentInformation.Models;
using System.Web.Mvc;
namespace StudentInformation.VModel
{
    public class StudentVModel
    {
        public StudentInfo Student { get; set; }
        public List<StudentInfo> StudentList { get; set; }
    }
}