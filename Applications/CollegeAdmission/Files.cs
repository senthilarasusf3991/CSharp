using System;
using System.IO;

namespace CollegeAdmission
{
    public class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("CollegeAdmission"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("CollegeAdmission");
            }
            else{
                System.Console.WriteLine("Folder exist");
            }
            if(!File.Exists("CollegeAdmission/StudentDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                var file=File.Create("CollegeAdmission/StudentDetails.csv");
                file.Close();


            }
            else{
                System.Console.WriteLine("File Existing....");
            }
        
            if(!File.Exists("CollegeAdmission/AdmissionDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                var file=File.Create("CollegeAdmission/AdmissionDetails.csv");
                file.Close();


            }
            else{
                System.Console.WriteLine("File Existing....");
            }
            if(!File.Exists("CollegeAdmission/DepartmentDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                var file=File.Create("CollegeAdmission/DepartmentDetails.csv");
                file.Close();


            }
            else{
                System.Console.WriteLine("File Existing....");
            }
        }
        //string studentName, string fatherName, DateTime dob, Gender holderGender,double physicsMark, double chemistryMark, double mathsMark
        public static void WriteToFiles()
        {
            string[] studentDetails = new string[Operations.studentList.Count];
            for (int i=0;i<Operations.studentList.Count;i++)
            {
                studentDetails[i]=Operations.studentList[i].StudentID+","+Operations.studentList[i].StudentName+","+Operations.studentList[i].FatherName+","+Operations.studentList[i].DOB.ToString("dd/MM/yyyy")+","+Operations.studentList[i].HolderGender+","+Operations.studentList[i].PhysicsMark+","+Operations.studentList[i].ChemistryMark+","+Operations.studentList[i].MathsMark;

            }
            File.WriteAllLines("CollegeAdmission/StudentDetails.csv",studentDetails);
            //string studentID, string departmentID, DateTime admissionDate, AdmissionStatus admissionStatus
            string[] admissionDetails = new string[Operations.admissionList.Count];
            for (int i=0;i<Operations.admissionList.Count;i++)
            {
                admissionDetails[i]=Operations.admissionList[i].AdmissionID+","+Operations.admissionList[i].StudentID+","+Operations.admissionList[i].DepartmentID+","+Operations.admissionList[i].AdmissionDate.ToString("dd/MM/yyyy")+","+Operations.admissionList[i].AdmissionStatus;

            }
            File.WriteAllLines("CollegeAdmission/AdmissionDetails.csv",admissionDetails);
            string[] departmentDetails = new string[Operations.departmentList.Count];
            for (int i=0;i<Operations.departmentList.Count;i++)
            {
                departmentDetails[i]=Operations.departmentList[i].DepartmentID+","+Operations.departmentList[i].DepartmentName+","+Operations.departmentList[i].NumberOfSeats;
            }
            File.WriteAllLines("CollegeAdmission/DepartmentDetails.csv",departmentDetails);

        }
        public static void Readfiles()
        {
            string[] studentInfo=File.ReadAllLines("CollegeAdmission/StudentDetails.csv");
            foreach(string data in studentInfo)
            {
                StudentDetails student=new StudentDetails(data);
                Operations.studentList.Add(student);
                
            }
            string[] admissionInfo=File.ReadAllLines("CollegeAdmission/AdmissionDetails.csv");
            foreach(string data in admissionInfo)
            {
                AdmissionDetails admission=new AdmissionDetails(data);
                Operations.admissionList.Add(admission);
                
            }
            string[] departmentInfo=File.ReadAllLines("CollegeAdmission/DepartmentDetails.csv");
            foreach(string data in departmentInfo)
            {
                DepartmentDetails department=new DepartmentDetails(data);
                Operations.departmentList.Add(department);
                
            }

        }
    }
}