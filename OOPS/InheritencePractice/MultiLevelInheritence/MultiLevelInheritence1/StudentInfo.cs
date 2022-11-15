using System;
namespace MultiLevelInheritence1
{
    public class StudentInfo:PersonalInfo
    {
        
    private static int s_registrationNumber=1000;
    public string RegisterNumber { get; set; }
    public string Standard { get; set; }
    public string Branch { get; set; }
    public DateTime AcadamicYear { get; set; }

    public StudentInfo(string name,string fatherName,string phone,string mail,DateTime dob,Gender gender,string standard,string branch,DateTime acadamicYear):base(name,fatherName,phone,mail,dob,gender)
    {
        s_registrationNumber++;
        RegisterNumber="STD"+s_registrationNumber;
        Standard=standard;
        Branch=branch;
        AcadamicYear=acadamicYear;
    }
    public void UpdateInfo(string name,string fatherName,string phone,string mail,DateTime dob,Gender gender,string standard,string branch,DateTime acadamicYear)
    {
        Name=name;
        FatherName=fatherName;
        Phone=phone;
        Mail=mail;
        Gender=gender;
        DOB=dob;
        Standard=standard;
        Branch=branch;
        AcadamicYear=acadamicYear;
    }
    public void ShowInfo()
    {
        ShowPersonalInfo();
        System.Console.WriteLine($"Register Number :{RegisterNumber}");
        System.Console.WriteLine($"Standard        :{Standard}");
        System.Console.WriteLine($"Branch          :{Branch}");
        System.Console.WriteLine($"Acadamic Year   :{AcadamicYear.ToString("yyyy")}");
    }
    }
}
