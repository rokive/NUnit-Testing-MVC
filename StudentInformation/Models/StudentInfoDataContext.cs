using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentInformation.Models
{
    public class StudentInfoDataContext
    {
        
        
        List<StudentInfo> studentInfoList = new List<StudentInfo>{
            new StudentInfo { Id = 1, Name = "Mahmudul Hassan Rokive", FatherName = "Shah Alam", Address = "H#1, Shimanto Shorok, Shonir Akhra, Jatrabari, Dhaka-1362",Class="0ne",Roll=1},
        new StudentInfo { Id = 2, Name = "Akash", FatherName = "Shah Alam", Address = "H#1, Shimanto Shorok, Shonir Akhra, Jatrabari, Dhaka-1362",Class="0ne",Roll=2}};
        
        public void InsertStudent(StudentInfo model)
        {
           
            
            studentInfoList.Add(model);
        }

        public void UpdateStudent(StudentInfo model)
        {
            studentInfoList.Select(m => new StudentInfo { Name = model.Name, FatherName = model.FatherName, Address = model.Address, Class = model.Class, Roll = model.Roll }).Where(m => m.Id == model.Id);
        }

        public IEnumerable<StudentInfo> GetAllStudent()
        {
            return studentInfoList;
        }

        public StudentInfo StudentGetbyId(int id)
        {
            return studentInfoList.Where(m => m.Id == id).FirstOrDefault();
        }
    }
}