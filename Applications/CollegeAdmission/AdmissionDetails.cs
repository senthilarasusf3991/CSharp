using System;
namespace CollegeAdmission
{
    public enum AdmissionStatus{Default, Admitted, Cancelled}
    public class AdmissionDetails
    {
        private static int s_admissionID=1000;
        public string AdmissionID{get;}
        public string StudentID{get; set;}
        public string DepartmentID{get; set;}
        public DateTime AdmissionDate{get; set;}
        public AdmissionStatus AdmissionStatus{get; set;}
        public AdmissionDetails(string studentID, string departmentID, DateTime admissionDate, AdmissionStatus admissionStatus)
        {
            s_admissionID++;
            AdmissionID="AID"+s_admissionID;
            StudentID=studentID;
            DepartmentID=departmentID;
            AdmissionDate=admissionDate;
            AdmissionStatus=admissionStatus;
        }
        public AdmissionDetails(string  data)
        {
            string[] values=data.Split(",");
            s_admissionID=int.Parse(values[0].Remove(0,3));
            AdmissionID=values[0];
            StudentID=values[1];
            DepartmentID=values[2];
            AdmissionDate=DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
            AdmissionStatus=Enum.Parse<AdmissionStatus>(values[4],true);



        }




    }
}