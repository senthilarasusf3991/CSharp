namespace MovieTicketBooking
{
    public class PersonalDetails
    {
        public string Name{get;set;}
        public int Age{get;set;}
        public long PhoneNumber{get;set;}
        public PersonalDetails(string name,int age,long phoneNumber)
        {
            Name=name;
            Age=age;
            PhoneNumber=phoneNumber;
        }
    }
}