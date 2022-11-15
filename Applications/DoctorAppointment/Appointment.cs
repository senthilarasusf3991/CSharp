using System;
namespace DoctorAppointment
{
    public class Appointment
    {
        private static int s_appointmentID=0;
        public int AppointmentID{get;}
        public int  PatientID{get;set;}
        public int DoctorID{get;set;}
        public DateTime Date{get;set;}
        public string Problem{get;set;}
        public Appointment(int patientID,int doctorID,DateTime date, string problem)
        {
            s_appointmentID++;
            AppointmentID=s_appointmentID;
            PatientID=patientID;
            DoctorID=doctorID;
            Date=date;
            Problem=problem;
        }
        public void ShowAppointmentDetails()
        {
             System.Console.WriteLine("| {0,-15} | {1,-15} | {2,-15} | {3,-15} | {4,-19} |",AppointmentID,PatientID,DoctorID,Date.ToString("dd/MM/yyyy"),Problem);
        }
    }
}