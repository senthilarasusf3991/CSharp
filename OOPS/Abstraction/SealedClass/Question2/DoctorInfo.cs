using System;
namespace Question2
{
    public class DoctorInfor:PatientInfo
    {
        private static int s_doctorID=1000;
        public string DoctorID { get; set; }
        public string DoctorName { get; set; }
        public string FatherName { get; set; }
        
        public void DisplayInfo()
        {
            Console.WriteLine($"DoctorID    :{DoctorID}");
            Console.WriteLine($"NAME        :{DoctorName}");
            Console.WriteLine($"Father name :{FatherName}");
            
            
            
        }
        
        
    }
}