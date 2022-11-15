using System;
using System.IO;

namespace Question5
{
    public delegate void Wire();
    public class Files
    {
        public static event Wire machineOne, machineTwo;
        public static void Create()
        {

            if(!Directory.Exists("Testfolder"))
            {
                Directory.CreateDirectory("Testfolder");
                System.Console.WriteLine("Folder Created");

            }
            else{
                System.Console.WriteLine("Folder exists");
            }
            if(!File.Exists("TestFolder/Test.txt"))
            {
                File.Create("TestFolder/Test.txt");
                System.Console.WriteLine(("File created"));

            }
            else{
                System.Console.WriteLine("File found");
            }
            System.Console.WriteLine("SELECT OPTION 1.Read File info 2.Write file info");
            int option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    machineOne += new Wire(Read);
                    machineOne();
                    break;
                }
                case 2:
                {
                    machineTwo += new Wire(Write);
                    machineTwo();
                    break;
                }
            
            }
        }
        public static void Read()
        {
            string line;
            StreamReader sr=null; //Create reader object to use readline method
            try{
                //pass the file path and file name to the streamreader constructor 
                sr = new StreamReader("TestFolder/Test.txt");
                line = sr.ReadLine();  //Read the first line of text
                while(line!=null)
                {
                    System.Console.WriteLine(line);  //write the line to console window
                    line=sr.ReadLine(); // Read the next line
                }
            }catch (Exception e) {System.Console.WriteLine("Exception: "+e.Message);}
            finally
            {
                if(sr!=null){System.Console.WriteLine("Executing finally block."); sr.Close();  }
            }
        }
        public static void Write()
        {
            StreamWriter sw=null;
            try
            {
                string [] old = File.ReadAllLines("TestFolder/Test.txt");
                //pass the file path and file name to the stramwriter constructor to open file
                sw=new StreamWriter("TestFolder/Test.txt");
                System.Console.WriteLine(("Enter new content to be placed in file: "));
                string info=Console.ReadLine();
                string old1="";
                foreach(string text in old)
                {
                    old1=old1+"\n"+text; //Append old text to make it as a single string 
                }
                old1=old1+"\n"+info; //Append our new user input to old text 
                sw.WriteLine(old1);

            }catch (Exception e)
            {System.Console.WriteLine("Exception: "+e.Message);}
            finally{//Close the file
            if(sw!=null){sw.Close();} }
        }
    }
}