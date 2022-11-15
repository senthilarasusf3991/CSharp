using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        MarkSheet marksheetDetails=new MarkSheet("2018203035","senthil","balu",9629254966,new DateTime(2000,10,02),Gender.Male,6,6,6,6,1125463,new DateTime(2022,08,15));
        System.Console.WriteLine("-----MARKSHEET DETAILS-----");
        marksheetDetails.MarkSheetDetails();
        marksheetDetails.CalulateUG();
        
        
    }
}