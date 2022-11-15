namespace TDD;
    
[TestFixture]
public class Tests 
{
   
    Calculator operation=null;
    
    [SetUp]
    public void Setup()
    {
         operation=new Calculator();

       

        
    }

    [Test]
    public void Test1()
    {
        int result=operation.Addtion(10,15);
        Assert.That(result,Is.EqualTo(25));
    }
    [TestCase(10,20,30)]
    [TestCase(1,2,3)]
    public void IsAddtionOk(int value1,int value2,int result)
    {
        int output=operation.Addtion(value1,value2);
        Assert.AreEqual(output,result);
    }

    [TestCase(1.5,2.5,4.0)]
    [TestCase(10.5,20.5,31.0)]
    public void IsAddtionOk(double value1,double value2,double result)
    {
        double output =operation.Addtion(value1,value2);
        Assert.AreEqual(output,result);
    }

    [TestCase("Ravi","Chandran","RaviChandran")]
    [TestCase("Baskaran","Sethurajan","BaskaranSethurajan")]
    public void IsAddtionOk(string value1,string value2,string result)
    {
        string output=operation.Addtion(value1,value2);
        Assert.AreEqual(output,result);
    }

}