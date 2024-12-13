using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using seiteAPI.Models.DTO;
using seiteAPI.Services.Context;
using Microsoft.AspNetCore.Mvc;

namespace seiteAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly StudentService _data;

        public StudentController(StudentService dataFromService)
        {
            _data = dataFromService;
        }

        //Add Student

        [HttpPost("AddStudent")]
        public bool AddStudent(StudentModel StudentToAdd)
        {
            return _data.AddStudent(StudentToAdd);
        }

        [HttpPost("DeleteStudent/{StudentToDeleteID}")]
        public bool DeleteStudent(int StudentToDeleteID)
        {
            return _data.DeleteStudent(StudentToDeleteID);
        }

        [HttpGet("GetStudentByUserId/{UserId}")]

        public IEnumerable<StudentModel> GetStudentsByUserId(int UserId)
        {
            return _data.GetStudentsByUserId(UserId);
        }


    }
}