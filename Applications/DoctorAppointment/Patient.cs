using System;
namespace DoctorAppointment
{
    public enum Gender{Default,Male,Female,Transgender}

    public class Patient
    {
        private static int s_patientID=0;
        public int PatientID{get;}
        public string Password{get;set;}
        public string PatientName{get;set;}
        public int PatientAge{get;set;}
        public Gender Gender{get;set;}
        public Patient(string password,string patientName,int patientAge,Gender gender)
        {
            s_patientID++;
            PatientID=s_patientID;
            Password=password;
            PatientName=patientName;
            PatientAge=patientAge;
            Gender=gender;
        }
        public void ShowPatientDetails()
        {
             System.Console.WriteLine("| {0,-15} | {1,-15} | {2,-15} | {3,-15} | {4,-15} |",PatientID,Password,PatientName,PatientAge,Gender);
        }
    }
}