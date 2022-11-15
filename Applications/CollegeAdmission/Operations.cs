using System;
namespace CollegeAdmission
{

    public  static partial  class Operations
    {
        public static StudentDetails studentObject;
        public static List<StudentDetails> studentList =new List<StudentDetails>();
        public static List<DepartmentDetails> departmentList= new List<DepartmentDetails>();
        public static List<AdmissionDetails> admissionList= new List<AdmissionDetails>();
        public static void MainMenu()
        {
            int option;
            System.Console.WriteLine("Welcome to Mainmenu");
            do
            {

            
                System.Console.WriteLine("1.User Registration 2.Login 3.Exit");
                option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        Login();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("exit");
                        break;
                    }
                    default:
                    {
                        System.Console.WriteLine("invalid choice");
                        break;
                    }
                }

            }while(option!=3);
            
        }
        
        private static void Registration()
        {
        
            Gender holderGender=Gender.Default;
            System.Console.WriteLine("Enter your Name: ");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your Father Name: ");
            string fatherName=Console.ReadLine();
            System.Console.WriteLine("Enter your date of birth ");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.WriteLine("Enter your gender Male,Female,Transgender ");
            while(!Enum.TryParse<Gender>(Console.ReadLine(),true,out holderGender) || !(((int)holderGender>0) && ((int)holderGender<4)))
            {
                System.Console.WriteLine("invalid entry");
            }
            System.Console.WriteLine("Enter your physics mark");
            int physicsMark=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Chemistry mark");
            int chemistryMark=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your physics mark");
            int mathsMark=int.Parse(Console.ReadLine());

            StudentDetails obStudent=new StudentDetails(name,fatherName,dob,holderGender,physicsMark,chemistryMark,mathsMark);
            studentList.Add(obStudent);
            System.Console.WriteLine("Your registration ID is : "+obStudent.StudentID);


            
        }

        private static void Login()
        {
            
            System.Console.WriteLine("Enter your StudentID; ");
            string studentID=Console.ReadLine().ToUpper();
            foreach(StudentDetails student in studentList)
            {
                if(studentID.Equals(student.StudentID))
                {
                    studentObject=student;
                    System.Console.WriteLine("StudentID exist");
                    SubMenu();
                    
                }
            }
            
        }


        private static void SubMenu()
        {
            int subOption;
             do
                {
                    System.Console.WriteLine("1.Check Eligibility 2.Show Details 3.Take Admission 4.Cancel Admission 5.Show Admission Details 6.Exit");
                    subOption=int.Parse(Console.ReadLine());
                    switch(subOption)
                    {
                        case 1:
                        {
                            CheckEligibility();
                            break;
                        }
                        case 2:
                        {
                            ShowDetails();
                            break;
                        }
                        case 3:
                        {
                            TakeAdmission();
                            break;
                        }
                        case 4:
                        {
                            CancelAdmission();
                            break;
                        }
                        case 5:
                        {
                            ShowAdmissionDetails();
                            break;
                        }
                        case 6:
                        {
                            System.Console.WriteLine("Exit");
                            break;
                        }
                    }
                }while(subOption!=6);

        }
        private static void CheckEligibility()
        {
            bool result = studentObject.CheckEligibility();
            
                if (result)
                {
                    System.Console.WriteLine("You are Eligible");
                }
                else{
                    System.Console.WriteLine("You are not eligible");
                }
            
        }
        private static void ShowDetails()
        {
            System.Console.WriteLine($"Name {studentObject.StudentName}");
            System.Console.WriteLine($"Father Name {studentObject.FatherName}");
            System.Console.WriteLine($"DOB {studentObject.DOB.ToShortDateString()}");
            System.Console.WriteLine($"Gender {studentObject.HolderGender}");
            
            System.Console.WriteLine($"Physics mark {studentObject.PhysicsMark}");
            System.Console.WriteLine($"Chemistry mark {studentObject.ChemistryMark}");
            System.Console.WriteLine($"Maths mark {studentObject.MathsMark}");
        }
        public static void DefaultStudentDetails()
        {
            StudentDetails student1=new StudentDetails("Ravichandran","Ettapparajan",Convert.ToDateTime("11/11/1999"),Gender.Male,95,95,95);
            StudentDetails student2=new StudentDetails("Baskaran","Sethurajan",Convert.ToDateTime("11/11/1999"),Gender.Male,95,95,95);
            studentList.Add(student1);
            studentList.Add(student2);
        }
        public static void DefaultDepartmetDetails()
        {
            DepartmentDetails department1=new DepartmentDetails(DepartmentName.EEE,29);
            DepartmentDetails department2=new DepartmentDetails(DepartmentName.CSE,29);
            DepartmentDetails department3=new DepartmentDetails(DepartmentName.MECH,30);
            DepartmentDetails department4=new DepartmentDetails(DepartmentName.ECE,30);
            departmentList.Add(department1);
            departmentList.Add(department2);
            departmentList.Add(department3);
            departmentList.Add(department4);
        }
        public static void DefaultAdmissionDetails()
        {
            AdmissionDetails admission1=new AdmissionDetails("SF3001","DID101",Convert.ToDateTime("11/05.2022"),AdmissionStatus.Admitted);
            AdmissionDetails admission2=new AdmissionDetails("SF3002","DID102",Convert.ToDateTime("12/05.2022"),AdmissionStatus.Admitted);
            
            admissionList.Add(admission1);
            admissionList.Add(admission2);
        }
        private static void ShowAdmissionDetails()
        {
            bool flag=true;
            foreach(AdmissionDetails admission in admissionList)
            {
                if(studentObject.StudentID.Equals(admission.StudentID))
                {
                    flag=false;
                    System.Console.WriteLine($"Student ID is {admission.StudentID}");
                    System.Console.WriteLine($"Admission ID is {admission.AdmissionID}");
                    System.Console.WriteLine($"Admission date is {admission.AdmissionDate.ToShortDateString()}");
                    System.Console.WriteLine($"Admission status is {admission.AdmissionStatus}");
                }   
            }
            if(flag)
                {
                    System.Console.WriteLine(("No details found"));
                }
        }
        private static void CancelAdmission()
        {
            foreach (AdmissionDetails admission in admissionList)
            {
                if((studentObject.StudentID.Equals(admission.StudentID) && (admission.AdmissionStatus==AdmissionStatus.Admitted)))
                {
                    
                    foreach(DepartmentDetails department in departmentList)
                    {
                        if(admission.DepartmentID.Equals(department.DepartmentID))
                        {
                            System.Console.WriteLine("Your admission cancelled successfully");
                            department.NumberOfSeats++;
                            admission.AdmissionStatus=AdmissionStatus.Cancelled;
                        }
                    }
                }

            }
        }
        private static void TakeAdmission()
        {
            bool iDflag = false, markFlag = false;
            foreach (DepartmentDetails department in departmentList)
            {
                System.Console.WriteLine($"Department name {department.DepartmentName}");
                System.Console.WriteLine($"Department id {department.DepartmentID}");
                System.Console.WriteLine($"Number of seats{department.NumberOfSeats}");
            }
            System.Console.WriteLine("Enter the Department ID to select department");
            string departmentID=Console.ReadLine().ToUpper();
            foreach (DepartmentDetails department in departmentList)
            {
                
                if(departmentID.Equals(department.DepartmentID) && department.NumberOfSeats>0)
                {
                    iDflag = true;
                    bool result = studentObject.CheckEligibility();
                    if (result)
                    {
                        markFlag = true;
                        bool flag = true;
                        System.Console.WriteLine("You are eligible");
                        foreach(AdmissionDetails admission in admissionList)
                        {
                            if(admission.StudentID== studentObject.StudentID && admission.AdmissionStatus==AdmissionStatus.Admitted)
                            {
                            flag=false;
                            System.Console.WriteLine("You have already taken admission, so you are not eligible");
                            }
                        }
                        if(flag)
                        {
                            department.NumberOfSeats--;
                            AdmissionDetails admission=new AdmissionDetails(studentObject.StudentID,department.DepartmentID,DateTime.Now,AdmissionStatus.Admitted);
                            admissionList.Add(admission);
                            System.Console.WriteLine("Your admission taken successfully your ID is "+admission.AdmissionID);
                        }
                    }
                        

                        
                }
                    
                     
            }
            if (!iDflag)
            {
                System.Console.WriteLine("Invalid Department ID...");
            }
            if (!markFlag)
            {
                System.Console.WriteLine("You are under Eligibility");
            }
            
        }
    
    }
}