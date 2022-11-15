using System;
namespace MedicalStore
{
    public class MedicineDetails
    {
        private static int s_medicineID=100;
        //Properties:
        public string MedicineID{get;}
        public string MedicineName{get; set;}
        public int AvailableCount{get; set;}
        public int Price{get; set;}
        public DateTime DateOfExpiry{get; set;}

        public MedicineDetails(string medicineName,int avalilableCount, int price, DateTime dateOfExpiry)
        {
            s_medicineID++;
            MedicineID="MD"+s_medicineID;
            MedicineName=medicineName;
            AvailableCount=avalilableCount;
            Price=price;
            DateOfExpiry=dateOfExpiry;


        }
    }
}