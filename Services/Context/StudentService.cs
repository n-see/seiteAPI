using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using seiteAPI.Services.Context;
using seiteAPI.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace seiteAPI.Services.Context
{
    public class StudentService : ControllerBase
    {
        private readonly DataContext _context;
        public StudentService(DataContext context)
        {
                _context = context;
        }
        public bool AddStudent(StudentModel newStudent)
        {
            bool result = false;
            _context.Add(newStudent);
            result = _context.SaveChanges() != 0;
            return result;
        }
        public bool DeleteStudent(int StudentToDeleteID)
        {
            //Delete the student via ID number
            StudentModel foundUser = GetStudentByID(StudentToDeleteID);
            bool result = false;
            if (foundUser != null)
            {
                foundUser.Id = StudentToDeleteID;
                _context.Remove<StudentModel>(foundUser);
                result = _context.SaveChanges() != 0;
            }
            return result;
        }

        public IEnumerable<StudentModel> GetAllStudents()
    {
        return _context.StudentInfo;
    }

        public IEnumerable<StudentModel> GetAllStudent()
        {
            return _context.StudentInfo;
        }
        
        public StudentModel GetStudentByID(int id)
        {
            return _context.StudentInfo.SingleOrDefault(student => student.Id == id);
        }

        public IEnumerable<StudentModel>GetStudentsByUserId(int userId)
        {
            return _context.StudentInfo.Where(student => student.UserId == userId && student.IsDeleted == false);
        }
    }
}