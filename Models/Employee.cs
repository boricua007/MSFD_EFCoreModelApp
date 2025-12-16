using System;

namespace MSDF_EFCoreModelApp.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfHire { get; set; }

        public int DepartmentID { get; set; }  // Foreign Key
        public Department Department { get; set; }  // Navigation Property

    }
}