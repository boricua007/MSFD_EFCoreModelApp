using System.Collections.Generic;

namespace MSDF_EFCoreModelApp.Models
{
    public class Department
    {
        public int DepartmentID { get; set; } // Primary Key
        public string Name { get; set; }
        public List<Employee> Employees { get; set; } // Navigation Property
    }
}