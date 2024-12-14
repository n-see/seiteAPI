using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using seiteAPI.Models.DTO;
using seiteAPI.Models;
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
        [HttpGet("GetStudentById/{Id}")]

        public IEnumerable<StudentModel> GetSpecificStudent(int Id)
        {
            return _data.GetSpecificStudent(Id);
        }

        [HttpGet("GetAllStudents")]
        public IEnumerable<StudentModel> GetAllStudent()
        {
            return _data.GetAllStudent();
        }

        // [HttpPut("{id:int}")]

        // public async Task<IActionResult> EditStudent(int id, StudentModel student)
        // {
        //     var studentFromDb = await _data.StudentInfo.findAsync(id);
        //     if(studentFromDb == null)
        //     {
        //         return BadRequest();

        //     }
        //         studentFromDb.Id = student.Id;
        //         studentFromDb.lastName = student.LastName;
        //         studentFromDb.firstName = student.FirstName;
        //         studentFromDb.SSId = student.SSId;
        //         studentFromDb.UserId = student.UserId;
        //         studentFromDb.ProfilePicture = student.ProfilePicture;
        //         studentFromDb.Gender = student.Gender;
        //         studentFromDb.Dob = student.Dob;
        //         studentFromDb.PrimaryDisability = student.PrimaryDisability;
        //         studentFromDb.PrimaryContact = student.PrimaryContact;
        //         studentFromDb.SecondaryContact = student.SecondaryContact;
        //         studentFromDb.HomeAddress = student.HomeAddress;
        //         studentFromDb.IsEnrolled = student.IsEnrolled;
        //         studentFromDb.IsDeleted = student.IsDeleted;

        //         var result = await _data.SaveChangesAsync();
        //         if (result > 0)
        //     {
        //         return Ok("Edit Successful");
        //     }
        //     return BadRequest("Unable to edit");
        // }

    }
}