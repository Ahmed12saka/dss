using System;
using System.ComponentModel;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;



namespace dss.Models
{
    public class Course
    {
            public Course()
            {
            }

            [Key]
            public int CourseId { get; set; }
            [DisplayName("Course Name")]
            public string CourseName { get; set; }
            [DisplayName("Course Code")]
            public string CourseCode { get; set; }
            [DisplayName("ECTS")]
            public int Credit { get; set; }

            public ICollection<Enrollment>? Enrollments { get; set; }

    }
}