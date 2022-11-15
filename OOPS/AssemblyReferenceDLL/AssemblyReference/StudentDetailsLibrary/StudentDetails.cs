using System;
/// <summary>
/// used to process the college admission using this application
/// </summary>
namespace StudentDetailsLibrary
{
    /// <summary>
    /// used to select a student's gender information
    /// </summary>
    public enum Gender {Default, Male, Female, TransGender }
    /// <summary>
    /// class <see cref="StudentDetails" />used to collect student's details for the admission process 
    /// </summary>
    public class StudentDetails

    {
        //Field
        /// <summary>
        /// Static field used to auto increment and it uniquely identify an instance of 
        /// <see cref "StudentDetails" />class
        /// </summary>
        private int s_registrationID=3000;    //field // s-static
        /// <summary>
        /// property register num used to uniquely identify a <see cref="StudentDetails" /> Class's object
        /// </summary>
        /// <value></value>
        public string RegistrationID { get;  }  //property
        
        
        public string StudentName { get; set; }     //Autoproperty
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
 

        public Gender StudentGender { get; set; }
        public string MailID { get; set; }
        public int  PhysicsMark { get; set; }
        public int  ChemistryMark { get; set; }
        public int  MathsMark { get; set; }

        /*
        public StudentDetails()           //default construct
        {
            StudentName="Your Name";
            PhysicsMark=40;
            ChemistryMark=46;
            MathsMark=41;

        }*/
        /// <summary>
        /// Constructor of <see cref="StudentDetails" /> class used to initiate value to its parameter
        /// </summary>
        /// <param name="studentName">parameter used to initialize values to its properties</param>
        /// <param name="fatherName"></param>
        /// <param name="dob"></param>
        /// <param name="gender"></param>
        /// <param name="mailId"></param>
        /// <param name="physicsMark"></param>
        /// <param name="chemistryMark"></param>
        /// <param name="mathsMark"></param>
        public StudentDetails(string studentName,string fatherName,DateTime dob ,Gender gender, string mailId , int physicsMark , int chemistryMark , int mathsMark)
        {
        s_registrationID++;                           //for field
         RegistrationID="SF"+s_registrationID;

         StudentName = studentName;
         FatherName= fatherName;
         DOB=dob;
         StudentGender = gender;
         MailID=mailId;
         PhysicsMark=physicsMark;
         ChemistryMark=chemistryMark;
         MathsMark=mathsMark;
        }
        ~StudentDetails()
        {
            System.Console.WriteLine("The destructor is called program is closing : ");
        }
        /// <summary>
        /// Method check eligibility get cutOff value as a parameter and checks the eligiblity of student
        /// If cutOff is less or equal than student is eligible and will return true else false
        /// </summary>
        /// <param name="cuttOff">Used to provide cutOff value for eligiblity checking</param>
        /// <returns>Returns true if eligible else false </returns>
        public bool CheckEligibility(double cuttOff)
        {
            double average=(double)(PhysicsMark+ChemistryMark+MathsMark)/3.0;
            if(average>cuttOff)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        
        
    }
}