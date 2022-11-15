using System;
namespace EBBill

{
    public class EBBillCalculation
    {
        private static int s_meterId=1000;
        public string Name {get; set;}
        public long PhoneNo {get; set;}
        public string MailID {get; set;}

        public double UnitsUsed {get; set;}
        public string MeterID {get;}



        public EBBillCalculation (string name,long phoneNo,string mailID, double unitsUsed )
        {
            s_meterId++;
            MeterID="EB"+s_meterId;
            Name=name;
            PhoneNo=phoneNo;
            MailID=mailID;
            UnitsUsed=unitsUsed;

        }
        public double CalculateAmount()
        {
            return UnitsUsed*5;
        }
    }
}