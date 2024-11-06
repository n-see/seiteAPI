using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Services.Context;
using API.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace API.Services.Context
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
        public bool DeleteStudent(StudentModel studentDelete)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StudentModel> GetAllStudents()
        {
            return _context.StudentInfo;
        }

    }
}