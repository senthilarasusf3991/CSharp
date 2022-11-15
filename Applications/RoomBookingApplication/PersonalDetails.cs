namespace RoomBookingApplication
{
    public enum FoodType{Default, Veg, NonVeg}
    public enum Gender{Default,Male,Female,Transgender }
    public class PersonalDetails
    {
        public string Name{get;set;}
        public long MobileNumber{get;set;}
        public long AadharNumeber{get;set;}
        public string Address{get;set;}
        public FoodType FoodType{get;set;}
        public Gender Gender {get;set;}

        public PersonalDetails(string name,long mobileNumber, long aadharNumber, string address, FoodType foodType, Gender gender)
        {
            Name=name;
            MobileNumber=mobileNumber;
            AadharNumeber=aadharNumber;
            Address=address;
            FoodType=foodType;
            Gender=gender;
        }


    }
}