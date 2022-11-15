namespace DoctorAppointment
{
    public class Doctor
    {
        private static int s_doctorID=0;
        public int DoctorID{get;}
        public string DoctorName{get;set;}
        public string Department{get;set;}
        public Doctor(string doctorName, string department)
        {
            s_doctorID++;
            DoctorID=s_doctorID;
            DoctorName=doctorName;
            Department=department;
        }

        public void ShowDoctorDetails()
        {
            System.Console.WriteLine("| {0,-15} | {1,-15} | {2,-15} |",DoctorID,DoctorName,Department);
        }
    }
}