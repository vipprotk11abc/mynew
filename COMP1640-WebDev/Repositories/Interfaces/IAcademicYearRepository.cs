﻿using COMP1640_WebDev.Models;

namespace COMP1640_WebDev.Repositories.Interfaces
{
    public interface IAcademicYearRepository
    {
        Task<IEnumerable<AcademicYear>> GetAcademicYears();
        Task<AcademicYear> GetAcademicYear(string idAcademicYear);
        Task<AcademicYear> CreateAcademicYear(AcademicYear academicYear);
        Task<AcademicYear> RemoveAcademicYear(string idAcademicYear);
        Task<AcademicYear> UpdateAcademicYear(string idAcademicYear, AcademicYear academicYear);
    }
}
