using System;
namespace SingleInheritence4
{
    public class DepartmentDetails
    {
        public string Department{get;set;}
        public string Degree{get;set;}
        public DepartmentDetails(string department, string degree)
        {
            Department=department;
            Degree=degree;
        }
    }
}