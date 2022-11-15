namespace Question1
{

    public class Attendance
    {
        public int TotalWorkingDays { get; set; }
        public float NumberOfLeaves { get; set; }
        public int NumberOfPermissions { get; set; }
        public Attendance(int totalWorkingDays,float numberOfLeaves,int numberOfPermissions)
        {
            TotalWorkingDays=totalWorkingDays;
            NumberOfLeaves=numberOfLeaves;
            NumberOfPermissions=numberOfPermissions;
        }
        public float TotalSalary()
        {
            return (TotalWorkingDays-NumberOfLeaves)*500;
        }
    }
}