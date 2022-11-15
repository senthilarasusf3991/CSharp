using System;
using System.Collections.Generic;

namespace CovidVaccineApplication
{
    public class Operations
    {
        private static List<BeneficiaryClass> beneficiariesList=new List<BeneficiaryClass>();
        private static List<VaccineClass> vaccinesList=new List<VaccineClass>();
        private static List<VaccinationClass> vaccinationsList=new List<VaccinationClass>();
        private static BeneficiaryClass currentBeneficiary;

        public static void DefaultDetails()
        {
            BeneficiaryClass beneficiary1=new BeneficiaryClass("Ravichandra",Gender.Male,"8484484","Chennai",21);
            BeneficiaryClass beneficiary2=new BeneficiaryClass("Baskaran",Gender.Male,"8484747","Chennai",22);
            VaccineClass vaccine1=new VaccineClass(VaccineName.Covishield,50);
            VaccineClass vaccine2=new VaccineClass(VaccineName.Covaccine,50);
            VaccinationClass vaccination1=new VaccinationClass("BID1001","CID101",DoseNumber.one,Convert.ToDateTime("11/11/2021"));
            VaccinationClass vaccination2=new VaccinationClass("BID1001","CID101",DoseNumber.Two,Convert.ToDateTime("11/03/2022"));
            VaccinationClass vaccination3=new VaccinationClass("BID1002","CID102",DoseNumber.one,Convert.ToDateTime("04/04/2022"));
            beneficiariesList.Add(beneficiary1);
            beneficiariesList.Add(beneficiary2);
            vaccinesList.Add(vaccine1);
            vaccinesList.Add(vaccine2);
            vaccinationsList.Add(vaccination1);
            vaccinationsList.Add(vaccination2);
            vaccinationsList.Add(vaccination2);

        }
        public static void MainMenu()
        {
            int option;
            System.Console.WriteLine("Welcome to Mainmenu");
            do
            {

            
                System.Console.WriteLine("1.Beneficiary Registration 2.Login 3.Get Vaccine Info 4.Exit");
                option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        Login();
                        break;
                    }
                    case 3:
                    {
                        GetVaccineInfo();
                        break;
                    }
                    case 4:
                    {
                        
                        break;
                    }
                    default:
                    {
                        System.Console.WriteLine("invalid choice");
                        break;
                    }
                }

            }while(option!=4);
            
        }
        private static void Registration()
        {
            Gender holderGender=Gender.Default;
            System.Console.WriteLine("Enter your name: ");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your age: ");
            int age=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your gender male , female, Transgender: ");
            while(!Enum.TryParse<Gender>(Console.ReadLine(),true,out holderGender) || !(((int)holderGender>0)&& ((int)holderGender<4)))
            {
                System.Console.WriteLine("invalid input enter again");

            }
            System.Console.WriteLine("Enter your mobile number: ");
            string mobileNo=Console.ReadLine();
            System.Console.WriteLine("Enter your City");
            string city=Console.ReadLine();

            BeneficiaryClass beneficiary=new BeneficiaryClass(name,holderGender,mobileNo,city,age);
            beneficiariesList.Add(beneficiary);
            System.Console.WriteLine($"Your registration ID is {beneficiary.RegistrationID}");
        }
        private static void Login()
        {
            System.Console.WriteLine("Enter your Login ID");
            string userID=Console.ReadLine().ToUpper();
            foreach(BeneficiaryClass beneficiary in beneficiariesList)
            {
                if(userID.Equals(beneficiary.RegistrationID))
                {
                    currentBeneficiary=beneficiary;
                    System.Console.WriteLine("Login Successfull");
                    SubMenu();
                }
                
            }
        }
        private static void SubMenu()
        {
                
            int subOption;
            do{
                System.Console.WriteLine("1.Show My Details");
                System.Console.WriteLine("2.Take Vaccination");
                System.Console.WriteLine("3.My Vaccination History");
                System.Console.WriteLine("4.Next Due Date");
                System.Console.WriteLine("5.Exit");
                System.Console.WriteLine("Enter the option");
                subOption=int.Parse(Console.ReadLine());
                switch(subOption)
                
                {
                    case 1:
                    {
                        ShowMYDetails();
                        break;
                    }
                    case 2:
                    {
                        TakeVaccination();
                        break;
                    }
                    case 3:
                    {
                        MyVaccinationHistory();
                        break;
                    }
                    case 4:
                    {
                        NextDueDate();
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("Thank You");
                        break;
                    }
                    default :
                    {
                        System.Console.WriteLine("Invalid Option enter the correct choice");
                        break;
                    }
                }


            }while(subOption!=5);
        }
        private static void ShowMYDetails()
        {
            System.Console.WriteLine($"Registration ID is :{currentBeneficiary.RegistrationID}");
            System.Console.WriteLine($"Name               :{currentBeneficiary.Name}");
            System.Console.WriteLine($"Age                :{currentBeneficiary.Age}");
            System.Console.WriteLine($"Gender             :{currentBeneficiary.HolderGender}");
            System.Console.WriteLine($"MobileNo           :{currentBeneficiary.MobileNO}");
            System.Console.WriteLine($"City               :{currentBeneficiary.City}");       
        }
        private static void TakeVaccination()
        {
            System.Console.WriteLine("|----------------------------------------------|");
            System.Console.WriteLine("|----------------------------------------------|");
            System.Console.WriteLine("| VaccineID | VaccineName | NoOFDosesAvailable |");
            foreach (VaccineClass Vaccine in vaccinesList)
            {
                System.Console.WriteLine("| {0,-9} | {1,-11} | {2,-18} |",Vaccine.VaccineID,Vaccine.VaccineName,Vaccine.NoOfDosesAvailable);
                System.Console.WriteLine(("|----------------------------------------------|"));
            }
            System.Console.WriteLine("Please select a vaccine by using vaccine ID");
            string userVaccineID=Console.ReadLine().ToUpper();
            bool flag =true;
            foreach(VaccineClass vaccine in vaccinesList)
            {
                if (userVaccineID.Equals(vaccine.VaccineID))
                {
                    flag=false;
                    foreach(VaccinationClass vaccination in vaccinationsList)
                    {
                        if (!currentBeneficiary.RegistrationID.Equals(vaccination.RegistrationID))
                        {
                            if(currentBeneficiary.Age<14)
                            {
                                System.Console.WriteLine("You are not Eligible to Take vaccine");
                            }
                            else{
                                System.Console.WriteLine($"You are successfully Vaccinated With {vaccine.VaccineID}");
                                
                                VaccinationClass newVaccination =new VaccinationClass(currentBeneficiary.RegistrationID,vaccine.VaccineID,DoseNumber.one,DateTime.Today);
                                vaccine.NoOfDosesAvailable--;
                                vaccinationsList.Add(newVaccination);
                                break;
                            }
                        }else{
                            if (userVaccineID.Equals(vaccination.VaccineID))
                            {
                                if((vaccination.HolderDoseNumber.Equals(DoseNumber.one)))
                                {
                                    if(vaccination.VaccinationDate.AddDays(30)<DateTime.Today)
                                    {
                                        System.Console.WriteLine("You are vaccinated with the Second Dose");
                                        VaccinationClass newVaccination = new VaccinationClass(currentBeneficiary.RegistrationID,vaccine.VaccineID,DoseNumber.Two,DateTime.Today);
                                        vaccine.NoOfDosesAvailable--;
                                        vaccinationsList.Add(newVaccination);
                                    }
                                    else{
                                        System.Console.WriteLine("Need to complelete 30 days after your vaccination");
                                    } 
                                }
                                else if(vaccination.HolderDoseNumber.Equals(DoseNumber.Two))
                                {
                                    if(vaccination.VaccinationDate.AddDays(30)<DateTime.Today)
                                    {
                                        System.Console.WriteLine("you are successfully vaccinated with your Third dose");
                                        VaccinationClass newVaccination=new VaccinationClass(currentBeneficiary.RegistrationID,vaccine.VaccineID,DoseNumber.Three,DateTime.Today);
                                        vaccine.NoOfDosesAvailable--;
                                        vaccinationsList.Add(newVaccination);
                                    }
                                    else{
                                        System.Console.WriteLine("Need to complete 30 days after your vaccination");
                                    }
                                }
                                else{
                                    System.Console.WriteLine("All the three Vaccination course are completed you cannot be vaccinated now");
                                }
                            }
                        }
                    }
                    if(flag)
                    {
                        System.Console.WriteLine("“You have selected different vaccine ”. You can vaccine with “Covaccine / Covishield (His first / second dose vaccine type)” ");
                    }

                }
            }
            
        }
        private static void MyVaccinationHistory()
        {
            foreach (VaccinationClass vaccination in vaccinationsList)
            { 
                if (currentBeneficiary.RegistrationID.Equals(vaccination.RegistrationID))
                {
                    System.Console.WriteLine("|---------------------------------------------------------------------");
                    System.Console.WriteLine("| VaccinationID | RegisterNumber | VaccineID | DoseNumber | VaccinatedDate |");
                    System.Console.WriteLine("|---------------------------------------------------------------------");
                    System.Console.WriteLine("| {0,-13} | {1,-14} | {0,-9} | {0,-10} | {0,-14} |",vaccination.VaccinationID,currentBeneficiary.RegistrationID,vaccination.HolderDoseNumber,vaccination.VaccinationDate);
                    System.Console.WriteLine("|---------------------------------------------------------------------");

                }
            }
        }
        private static void NextDueDate()
        {
            bool flag=true;
            foreach(VaccinationClass vaccination in vaccinationsList)
            {
                
                if (currentBeneficiary.RegistrationID==vaccination.RegistrationID)
                {
                    flag=false;
                    if(vaccination.HolderDoseNumber==DoseNumber.one)
                    {
                        System.Console.WriteLine($"Your next vaccination date is {vaccination.VaccinationDate.AddDays(30)}");
                        return;
                    }
                    else if(vaccination.HolderDoseNumber==DoseNumber.Two)
                    {
                        System.Console.WriteLine($"Your next vaccination date is {vaccination.VaccinationDate.AddDays(30)}");
                        return;
                    }
                    else{
                        System.Console.WriteLine("“You have completed the vaccination course. Thanks for your participation in the vaccination drive.”");
                        return; 
                    }
                }
            }
            if(flag)
            {
                System.Console.WriteLine("“you can take vaccine now”.");
                return;
            }
        }
        private static void GetVaccineInfo()
        {
            System.Console.WriteLine("|----------------------------------------------|");
            System.Console.WriteLine("|----------------------------------------------|");
            System.Console.WriteLine("| VaccineID | VaccineName | NoOFDosesAvailable |");
            foreach (VaccineClass Vaccine in vaccinesList)
            {
                System.Console.WriteLine("| {0,-9} | {1,-11} | {2,-18} |",Vaccine.VaccineID,Vaccine.VaccineName,Vaccine.NoOfDosesAvailable);
                System.Console.WriteLine(("|----------------------------------------------|"));
            }
        }
            
        

    }
}
