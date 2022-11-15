using System;
namespace Question2
{
    public sealed class PatientInfo
    {
        private static int s_patientID=1000;
        public string PatientID { get; set; }
        public string PatientName { get; set; }
        public string FatherName { get; set; }
        public int BedNo { get; set; }
        public string NativePlace { get; set; }
        public string AdmittedFor { get; set; }
        public PatientInfo(string patientName,string fatherName,int bedNo,string nativePlace,string admittedFor)
        {
            s_patientID++;
            PatientID="PID"+s_patientID;
            PatientName=patientName;
            FatherName=fatherName;
            BedNo=bedNo;
            NativePlace=nativePlace;
            AdmittedFor=admittedFor;
        }
        public void DisplayInfo()
        {
            System.Console.WriteLine($"PatientID is      :{PatientID}");
            System.Console.WriteLine($"Name is           :{PatientName}");
            System.Console.WriteLine($"FatherName is     :{FatherName}");
            System.Console.WriteLine($"BedNo is          :{BedNo}");
            System.Console.WriteLine($"NativePlace is    :{NativePlace}");
            System.Console.WriteLine($"Admitted for      :{AdmittedFor}");
        }
        
        
        
        
        
        
    }
}