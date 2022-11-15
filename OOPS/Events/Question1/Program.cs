namespace Question1
{
    
    public class Program
    {
        public static event Holder functions;
        public static void Main(string[] args)
        {
            StudentDetails student = new StudentDetails();
            functions += new Holder(student.GetDetails);
            functions += new Holder(student.Calculate);
            functions();
        }
    }
}