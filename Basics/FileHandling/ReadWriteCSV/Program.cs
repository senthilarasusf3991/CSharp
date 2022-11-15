
using System;
using System.IO;
using System.Collections.Generic;
namespace ReadWriteCSV
{
    class Program
    {
        public static void Main(string[] args)
        {
            if(!Directory.Exists("TestFolder"))
            {
                Directory.CreateDirectory("TestFolder");
                System.Console.WriteLine("FolderCreated");

            }
            else{
                System.Console.WriteLine(("Folder found"));
            }
            if(!File.Exists("Testfolder/Data.csv"))
            {
                System.Console.WriteLine("File doesn't exist.Creating a new CSV file");
                File.Create("TestFolder/Data.csv").Close(); //var fs=File.Open ("out.csv,Filemode.Openor create); fs.close


            }
            else{System.Console.WriteLine("Files found");}

            List<Student>vlist=new  List<Student>();
            vlist.Add(new Student(){Name="Senthil",FatherName="balu",Gender=Gender.Male,DOB=new DateTime(2000,10,10)});
            vlist.Add(new Student(){Name="arun",FatherName="arri",Gender=Gender.Male,DOB=new DateTime(1999,10,10)});
            vlist.Add(new Student(){Name="viky",FatherName="vinoth",Gender=Gender.Male,DOB=new DateTime(1998,10,10)});
            Insert(vlist);
            Display();
            

        }
        static void Insert(List<Student>vlist)
        {
            StreamWriter write=null;
            write = new StreamWriter(File.OpenWrite("TestFolder/Data.csv"));
            foreach(Student student in vlist)
            {
                write.WriteLine(student.Name+","+student.FatherName+","+student.Gender+","+student.DOB.ToString("dd/MM/yyyy"));
            }
            write.Close();
        }
        static void Display()
        {
            StreamReader reader=null;
            List<Student> listA=new List<Student>();
            if(File.Exists("TestFolder/Date.csv"))
            {
                reader = new StreamReader(File.OpenRead("TestFolder/Data.csv"));
                while(!reader.EndOfStream)
                {
                    var line=reader.ReadLine();
                    var values=line.Split(',');
                    if(values[0]!="")
                    {
                        listA.Add(new Student(){Name=values[0],FatherName=values[1],Gender=Enum.Parse<Gender>(values[2]),DOB=DateTime.ParseExact(values[3],"dd/MM/yyyy",null)});

                    }

                }
            }
            else{
                System.Console.WriteLine("File Doesn't Exist");
                if(reader!=null)
                reader.Close();
                foreach(var coloumn1 in listA)
                {System.Console.WriteLine("Your Name:\t"+coloumn1.Name+"\t Father Name:\t"+coloumn1.FatherName+"\t Gender is:\t"+coloumn1.DOB.ToShortDateString());}
            }
        }
    }
}