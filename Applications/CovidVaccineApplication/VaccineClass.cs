using System;


namespace CovidVaccineApplication
{
    public enum VaccineName{Default, Covishield, Covaccine}
    public class VaccineClass
    {
        private static int s_vaccineID=100;
        public string VaccineID{get;}
        public VaccineName VaccineName{get; set;}
        public int NoOfDosesAvailable{get; set;}

        public VaccineClass(VaccineName holderVaccine, int noOfDosesAvailable)
        {
            s_vaccineID++;
            VaccineID="CID"+s_vaccineID;
            VaccineName=holderVaccine;
            NoOfDosesAvailable=noOfDosesAvailable;
        }
        
    }
}