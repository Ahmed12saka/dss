using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace dss.Models
{
    public enum Gender
    {
        Male, Female
    }

    public class Student
    {
        public Student()
        {
        }
        [Key]
        public int StudentId { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Date of Birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DOB { get; set; }
        [DisplayName("Enrollment Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime EnrollmentDate { get; set; }
        public Gender? Gender { get; set; }
        [DisplayName("School Name")]
        public int SchoolId { get; set; }
        [DisplayName("Student Name")]
        public string StudentName { get { return this.FirstName + " " + this.LastName; } }

        public ICollection<Enrollment>? Enrollments { get; set; }

        [DisplayName("School")]
        public School? School { get; set; }
    }
}
