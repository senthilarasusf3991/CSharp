using System;
using System.Collections.Generic;
namespace CovidVaccineApplication
{
    public enum DoseNumber {Default, one, Two, Three }
    public class VaccinationClass
    {
        private static int s_vaccinationID=1000;
        public string VaccinationID{get;}
        public string RegistrationID{get;set;}
        public string VaccineID{get; set;}
        public DoseNumber HolderDoseNumber{get; set;}
        public DateTime VaccinationDate {get; set;}

        public VaccinationClass(string registrationID, string vaccineID,DoseNumber doseNumer, DateTime vaccinationDate)
        {
            s_vaccinationID++;
            VaccinationID="VID"+s_vaccinationID;
            RegistrationID=registrationID;
            VaccineID=vaccineID;
            HolderDoseNumber=doseNumer;
            VaccinationDate=vaccinationDate;
        }
    }
}