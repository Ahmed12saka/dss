using System;
using System.Collections.Generic;
using dss.Models;
using static dss.Models.Course;

namespace dss.Services
{
    public interface ICourse
    {
        IEnumerable<Course> GetCourses { get; }

        Course GetCourse(int Id);
        void Add(Course _Course);
        void Remove(int Id);
    }
}
