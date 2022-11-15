using System;
using System.IO;
namespace Files;
class Program
{
    public static void Main(string[] args)
    {
        String path=@"C:\Users\SenthilarasuBalu\OneDrive - Syncfusion\Desktop\MyFolder";
        string folderPath=path+"/Senthil";
        if(!Directory.Exists(folderPath))
        {
            System.Console.WriteLine("Folder not found.So, creating folder");
            Directory.CreateDirectory(folderPath);

        }
        else{
            System.Console.WriteLine("Directory found");
        }
        string filePath=path+"/newFile.txt";
        if(!File.Exists(filePath))
        {
            System.Console.WriteLine("Folder not found.So, creating file");
            File.Create(filePath);

        }
        else{
            System.Console.WriteLine("file already found");
        }
        System.Console.WriteLine("SELECT OPTION 1.Create Folder 2.Create File 3.Delete Folder 4.Delete File  ");
        int option=int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                System.Console.WriteLine("Enter folder name you want to create: ");
                string name1=Console.ReadLine();
                string newPath=path+"//"+name1;
                if(!Directory.Exists(newPath))
                {
                    System.Console.WriteLine("Creating folder "+name1);
                    Directory.CreateDirectory(newPath);

                }
                else
                {
                    System.Console.WriteLine(("Directory name already Exists"));
                    
                }
                break;
            }
            case 2:
            {
                System.Console.WriteLine("Enter file name you want to create: ");
                string name=Console.ReadLine();
                System.Console.WriteLine("Enter file extention you want to create");
                string extention =Console.ReadLine(); 
                string newPath=path+"\\"+name+"."+extention;
                if(!File.Exists(newPath))
                {
                    System.Console.WriteLine("Creating file "+name);
                    Directory.CreateDirectory(newPath);

                }
                else
                {
                    System.Console.WriteLine(("File name already Exists"));
                    
                }
                break;
            }
            case 3:
            {
                foreach(string name in Directory.GetDirectories(path)) //Its like a file manager.
                {System.Console.WriteLine(name);}
                System.Console.WriteLine("Select folder you want to delete");
                string name1=Console.ReadLine();
                string newPath=path+"\\"+name1;
                try{
                    foreach(string name in Directory.GetDirectories(path))
                    {
                        if (name==newPath) //check folder matches
                        {
                            Directory.Delete(newPath);
                            System.Console.WriteLine("Folder Deleted");
                        }
                    }
                }catch(DirectoryNotFoundException e)
                {
                    System.Console.WriteLine("Directory not found");
                }
                break;


            }
            case 4:
            {
                foreach(string name in Directory.GetFiles(path)) //Its like a file manager.
                {System.Console.WriteLine(name);}
                System.Console.WriteLine("Select file you want to delete");
                string name1=Console.ReadLine();
                System.Console.WriteLine("Enter file extention you want to delete");
                string name2=Console.ReadLine();
                
                string newPath=path+"\\"+name1+"."+name2;
                try
                {
                    
                
                    foreach(string name in Directory.GetFiles(path))
                    {
                        if (name==newPath) //check folder matches
                        {
                            File.Delete(newPath);
                            System.Console.WriteLine("File Deleted");
                        }
                    }
                }catch(FileNotFoundException e)
                {
                    System.Console.WriteLine("File not found");
                }
                break;


            }
        }
    }
}