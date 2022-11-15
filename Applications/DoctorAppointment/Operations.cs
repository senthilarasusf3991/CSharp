using System;
using System.Collections.Generic;
namespace DoctorAppointment
{
    public class Operations
    {
        public static List<Doctor> doctorList =new List<Doctor>();
        public static List<Patient> patientList=new List<Patient>();
        public static List<Appointment> appointmentList=new List<Appointment>();
        public static Patient CurrentPatient;

        public static void MainMenu()
        {
            int option;

            System.Console.WriteLine("WELCOME");
            do{
                System.Console.WriteLine("Select the option: \n1.Login\n2.Register\n3.Exit");
                option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("LOGIN");
                        Login();
                        break;                        
                    }
                    case 2:
                    {
                        System.Console.WriteLine("REGISTRATION");
                        Registration();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("ThankYou!!");
                        break;
                    }
                    default :
                    {
                        System.Console.WriteLine("Option invalid Enter the correct Option");
                        break;
                    }
                    
                }
            }while(option!=3);
            
        }
        private static void Registration()
        {
            bool temp;
            int patientAge;
            Gender gender=Gender.Default;
            System.Console.WriteLine("Enter your name: ");
            string patientName=Console.ReadLine();
            System.Console.WriteLine("Enter Your password you want to enter: ");
            string password=Console.ReadLine();
            System.Console.WriteLine("Enter your age: ");
            temp=int.TryParse(Console.ReadLine(),out patientAge);
            while(!temp)
            {
                System.Console.WriteLine("Enter your age in numbers: ");
                temp=int.TryParse(Console.ReadLine(),out patientAge);
                
            }
            System.Console.WriteLine("Enter your gender Male,Female,Transgender: ");
            while(!Enum.TryParse<Gender> (Console.ReadLine(),true,out gender) || !(((int)gender>0) && ((int)gender<4)))
            {
                System.Console.WriteLine("Invalid choice,,Enter again");
            }

            Patient newPatient=new Patient(password,patientName,patientAge,gender);
            patientList.Add(newPatient);
            Console.ForegroundColor=ConsoleColor.Green;
            System.Console.WriteLine($"Registration Successfull Your PatientID is {newPatient.PatientID}");
            Console.ResetColor();

        }
        private static void Login()
        {
            
            bool flag=true;
            System.Console.WriteLine("Enter Your user name in correct format: ");
            string patientName=Console.ReadLine();
            System.Console.WriteLine("Enter Your password:");
            string password=Console.ReadLine();
            foreach(Patient patient in patientList)
            {
                if(patient.PatientName.Equals(patientName)&&patient.Password.Equals(password))
                {
                    flag=false;
                    CurrentPatient=patient;
                    Console.ForegroundColor=ConsoleColor.Green;
                    System.Console.WriteLine("Patient found");
                    Console.ResetColor();
                    PatientMenu();

                }
            }
            if(flag)
            {
                Console.ForegroundColor=ConsoleColor.Red;
                System.Console.WriteLine("Sorry, your record is invalid.Please register your profile and log in again");
                Console.ResetColor();
            }
        }
        private static void PatientMenu()
        {
            int option;
            do
            {
            
            System.Console.WriteLine("Enter Your Choice.");
            System.Console.WriteLine("1.Book Appointment\n2.View Appointment details\n3.Edit my profile\n4.Exit");
            option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    BookAppointmet();
                    break;
                }
                case 2:
                {
                    ViewAppointment();
                    break;
                }
                case 3:
                {
                    EditMyProfile();
                    break;
                }
                case 4:
                {
                    
                    break;
                }
                default:
                {
                    System.Console.WriteLine("Invalid Option Enter the correct Option");
                    break;
                }
            }
            }while(option!=4);

        }
        private static void BookAppointmet()
        {
            
            int option;
            do{
                System.Console.WriteLine("Select the department from the below List:");
                System.Console.WriteLine("1.Anaesthesiology\n2.Cardiology\n3.Diabetology\n4.Neonatology\n5.Nephrology");
                option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {

                        AvailableAppointment("Anaesthesiology");
                        break;
                    }
                    case 2:
                    {
                        AvailableAppointment("Cardiology");
                        break;
                    }case 3:
                    {
                        AvailableAppointment("Diabetology");
                        break;
                    }case 4:
                    {
                        AvailableAppointment("Neonatology");
                        break;
                    }case 5:
                    {
                        AvailableAppointment("Nephrology");
                        break;
                    }
                    default:
                    {
                        System.Console.WriteLine("Invalid choice");
                        break;
                    }

                }
            }while(option>5);
            
            
            
        }
        private static void ViewAppointment()
        {
            bool flag=true;
            System.Console.WriteLine("|---------------------------------------------------------------------------------------------|");
            System.Console.WriteLine("|   AppointmentID |   PatientID     |     DoctorID    |   Date          |   Problem           |");
            System.Console.WriteLine("|---------------------------------------------------------------------------------------------|");
            foreach(Appointment appointment in appointmentList)
            {
                if(appointment.PatientID.Equals(CurrentPatient.PatientID))
                {
                    flag=false;
                    appointment.ShowAppointmentDetails();
                    System.Console.WriteLine("|---------------------------------------------------------------------------------------------|");
                }

            }
            if(flag)
            {
                System.Console.WriteLine("No Appoitment history in your ID");
            }
        }
        private static void EditMyProfile()
        {
            Gender gender=Gender.Default;
            int patientAge;
            int option;
            bool temp;
            do{
                System.Console.WriteLine("Enter the Option that you want to update: ");
                System.Console.WriteLine("1.Name\n2.Password\n3.Age\n4.Gender");
                option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Enter Your name to modify: ");
                        CurrentPatient.PatientName=Console.ReadLine();
                        System.Console.WriteLine($"Your Name is: {CurrentPatient.PatientName}");
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Enter Your Password to modify: ");
                        CurrentPatient.Password=Console.ReadLine();
                        System.Console.WriteLine($"Your Password is: {CurrentPatient.Password}");
                        
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Enter your age: ");
                        temp=int.TryParse(Console.ReadLine(),out patientAge);
                        while(!temp)
                        {
                            System.Console.WriteLine("Enter your age in numbers: ");
                            temp=int.TryParse(Console.ReadLine(),out patientAge);
                            
                        }
                        CurrentPatient.PatientAge=patientAge;
                        System.Console.WriteLine($"Your age is: {CurrentPatient.PatientAge}");
                        break;
                        
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Enter Your Gender to modify: ");
                        while(!Enum.TryParse<Gender> (Console.ReadLine(),true,out gender) || !(((int)gender>0) && ((int)gender<4)))
                        {
                            System.Console.WriteLine("Invalid choice,,Enter again");
                        }
                        CurrentPatient.Gender=gender;
                        System.Console.WriteLine($"Your age is: {CurrentPatient.Gender}");
                        
                        break;
                    }
                }
            }while(option>4);
        }
        private static void AvailableAppointment(string department)
        {
            string problem;
            char character;
            int doctorID=0;
            int appointmentCount=0;
            foreach(Doctor doctor in doctorList)
            {
                if(department.Equals(doctor.Department))
                {
                    doctorID=doctor.DoctorID;
                    foreach(Appointment appointment in appointmentList)
                    {
                        if(doctor.DoctorID.Equals(appointment.DoctorID)&& DateTime.Now.Date.Equals(appointment.Date))
                        {
                            appointmentCount++;
                        }
                    }
                }
            }
            if(appointmentCount<=1)
            {
                System.Console.WriteLine($"Appointment is confirmed , Available appointment date is {DateTime.Now.ToString("dd/MM/yyyy")}");
                System.Console.WriteLine("For Booking press 'Y' to Cancel Booking press 'N' :");
                character=Char.Parse(Console.ReadLine().ToUpper());

                if(character.Equals('Y'))
                {
                    System.Console.WriteLine("Enter Your Problem for Appointment: ");
                    problem=Console.ReadLine();
                    Appointment newAppoinmet=new Appointment(CurrentPatient.PatientID,doctorID,DateTime.Now.Date,problem);
                    appointmentList.Add(newAppoinmet);
                    Console.ForegroundColor=ConsoleColor.Green;
                    System.Console.WriteLine($"Appointmet Successfully Booked, Your Appointment ID {newAppoinmet.AppointmentID}");
                    Console.ResetColor();

                }
            }
            else
            {
                System.Console.WriteLine($"Appointment is confirmed, available appointment date is {DateTime.Now.AddDays(1).ToString("dd/MM/yyyy")}");
                System.Console.WriteLine("For Booking press 'Y' to Cancel Booking press 'N' :");
                character=Char.Parse(Console.ReadLine().ToUpper());

                if(character.Equals('Y'))
                {
                    System.Console.WriteLine("Enter Your Problem for Appointment: ");
                    problem=Console.ReadLine();
                    Appointment newAppoinmet=new Appointment(CurrentPatient.PatientID,doctorID,DateTime.Now.AddDays(1).Date,problem);
                    appointmentList.Add(newAppoinmet);
                    Console.ForegroundColor=ConsoleColor.Green;
                    System.Console.WriteLine($"Appointmet Successfully Booked, Your Appointment ID {newAppoinmet.AppointmentID}");
                    Console.ResetColor();

                }
            }
        }

        public static void DefaultData()
        {
            Doctor doctor1=new Doctor("Nancy","Anaesthesiology");
            Doctor doctor2=new Doctor("Andrew","Cardiology");
            Doctor doctor3=new Doctor("Janet","Diabetology");
            Doctor doctor4=new Doctor("Margaret","Neonatology");
            Doctor doctor5=new Doctor("Steven","Nephrology");

            doctorList.Add(doctor1);
            doctorList.Add(doctor2);
            doctorList.Add(doctor3);
            doctorList.Add(doctor4);
            doctorList.Add(doctor5);

            Patient patient1=new Patient("welcome","Robert",40,Gender.Male);
            Patient patient2=new Patient("welcome","Laura",36,Gender.Female);
            Patient patient3=new Patient("welcome","Anne",42,Gender.Female);
            patientList.Add(patient1);
            patientList.Add(patient2);
            patientList.Add(patient3);

            Appointment appointment1=new Appointment(1,2,new DateTime(2012,03,08),"Heart Problem");
            Appointment appointment2=new Appointment(1,5,new DateTime(2012,03,08),"Spinal Cord Injury");
            Appointment appointment3=new Appointment(2,2,new DateTime(2012,03,08),"Heart attack");

            appointmentList.Add(appointment1);
            appointmentList.Add(appointment2);
            appointmentList.Add(appointment3);



        }
    }
}