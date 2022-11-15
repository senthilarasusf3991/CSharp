using System;
namespace CafeteriaCardManagement
{
    public enum Gender{Default, Male, Female,TransGender}
    public class PersonalDetails
    {
        /// <summary>
        /// Belongs to class <see Cref ="PersonalDetails"/> that stores the Name of the Person
        /// </summary>
        /// <value></value>
        public string Name{get;set;}
        /// <summary>
        /// Belongs to class <see Cref ="PersonalDetails"/> that stores the FatherName of the Person
        /// </summary>
        /// <value></value>
        public string FatherName { get; set; }
        /// <summary>
        /// Belongs to class <see Cref ="PersonalDetails"/> that stores the Persons Gender
        /// </summary>
        /// <value></value>
        public Gender Gender{get;set;}
        /// <summary>
        /// Belongs to class <see Cref ="PersonalDetails"/> that stores the MobileNumber of the Person
        /// </summary>
        /// <value></value>
        public long MobileNumber{get;set;}
        /// <summary>
        /// Belongs to class <see Cref ="PersonalDetails"/> that stores the Mail Identity of the Person
        /// </summary>
        /// <value></value>
        public string MailID{get;set;}
        /// <summary>
        /// Belongs to the class <see Cref="Personal Details"/> that initiates the property and methods of class
        /// </summary>
        /// <param name="name">Passes the name of Person</param>
        /// <param name="fatherName">Passes the Father name of Person</param>
        /// <param name="gender">Passes the Gender of Person</param>
        /// <param name="mobileNumber">Passes the Mobile number of the person</param>
        /// <param name="mailID">Passes the Mail Identity of the person</param>

        public PersonalDetails(string name,string fatherName, Gender gender,long mobileNumber,string mailID )
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            MobileNumber=mobileNumber;
            MailID=mailID;
        }


        
    }
}