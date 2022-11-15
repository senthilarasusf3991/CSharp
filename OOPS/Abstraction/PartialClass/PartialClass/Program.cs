namespace PartialClass
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee employee=new Employee(124,"jack");
            employee.DisplayEmpInfo();
            employee.ShowEmployeeID();
        }
    }
}