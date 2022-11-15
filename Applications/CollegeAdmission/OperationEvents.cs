namespace CollegeAdmission
{
    public delegate void EventManager();  //user defined delegate
    public static partial class Operations
    {
        
        public static event EventManager starter;
        public static event EventManager registration,login,check,showDetail,takeAdmission,cancel,showAdmissionDetails;

        public static void Starter(){Subscribe(); starter();}
        public static void Subscribe()
        {
            starter+= new EventManager(Files.Create); 
            starter+= new EventManager(Files.Readfiles);
            starter+= new EventManager(MainMenu);
            starter+= new EventManager(Files.WriteToFiles);
            login+=new EventManager(Login);
            check+= new EventManager(CheckEligibility);
            showDetail+= new EventManager(ShowDetails);
            takeAdmission+= new EventManager(TakeAdmission);
            cancel+= new EventManager(CancelAdmission);
            showAdmissionDetails+=new EventManager(ShowAdmissionDetails);





            

        }
    }
}