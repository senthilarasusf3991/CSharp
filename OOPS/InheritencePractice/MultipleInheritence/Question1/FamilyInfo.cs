namespace Question1
{
    public interface IFamilyInfo:IShowData
    {
        public string FatherName{get;set;}
        public string MotherName{get;set;}
        public string HouseAdress{get;set;}
        public int NoOfSibilings{get;set;}

    }
}