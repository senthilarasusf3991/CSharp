using System;
namespace CollegeAdmission
{
    public enum DepartmentName{Default, EEE, CSE, MECH, ECE}
    public class DepartmentDetails
    {
        private static int s_departmentID=100;
        public string DepartmentID{get;}

        public DepartmentName DepartmentName{get; set;}
        
        public int NumberOfSeats{get; set;}
        public DepartmentDetails(DepartmentName departmentName, int numberOfSeats)
        {
            s_departmentID++;
            DepartmentID="DID"+s_departmentID;
            DepartmentName=departmentName;
            NumberOfSeats=numberOfSeats;
        }
         public DepartmentDetails(string  data)
         {
            string[] values=data.Split(",");
            s_departmentID=int.Parse(values[0].Remove(0,3));
            DepartmentID=values[0];
            DepartmentName=Enum.Parse<DepartmentName>(values[1],true);
            NumberOfSeats=int.Parse(values[2]);

         }
    }
}