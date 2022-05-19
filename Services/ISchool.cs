using System;
using System.Collections.Generic;
using dss.Models;

namespace dss.Services
{
    public interface ISchool
    {
        IEnumerable<School> GetSchools { get; }

        School GetFaculty(int Id);
        void Add(School _School);
        void Remove(int Id);
    }
}
    
