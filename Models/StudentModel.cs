using System;


namespace API.Models.DTO
{
 public class StudentModel
    {
        public int Id { get; set; }
        public string? ProfilePicture { get; set; }
        public DateTime Dob { get; set; }
        public int Age => CalculateAge(Dob);
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PrimaryDisability { get; set; }
        public string? PrimaryContact { get; set; }
        public string? SecondaryContact { get; set; }
        public string? HomeAddress { get; set; }
        public bool IsEnrolled { get; set; }
        public bool IsDeleted { get; set; }
        public StudentModel() { }

        private int CalculateAge(DateTime dob)
        {
            var today = DateTime.Today;
            var age = today.Year - dob.Year;
            if (dob.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
}