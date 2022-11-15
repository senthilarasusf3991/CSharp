namespace OnlineLibraryManagement
{
    public enum Gender {Default, Male, Female, Transgender}
    public enum Department{Default, ECE, EEE, CSE}

    public class UserDetails
    {
        private static int s_registrationID=3000;
        public string RegistrationID{get;}
        public string UserName{get; set;}
        public  Gender HolderGender {get; set;}
        public Department Department {get; set;}
        public string MobileNo {get; set;}
        public string MailID {get; set;}

        public UserDetails (string username, Gender holderGender, Department department, string mobileNO, string mailID)
        {
            s_registrationID++;
            RegistrationID="SF"+s_registrationID;
            UserName=username;
            HolderGender=holderGender;
            Department=department;
            MobileNo=mobileNO;
            MailID=mailID;
        }
    }
}