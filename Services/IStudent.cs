using System;
using System.Collections.Generic;
using dss.Models;


namespace dss.Services
{
    public interface IStudent
    {
        IEnumerable<Student> GetStudents { get; }

        Student GetStudent(int? Id);
        void Add(Student _Student);
        void Remove(int? Id);
    }
}
