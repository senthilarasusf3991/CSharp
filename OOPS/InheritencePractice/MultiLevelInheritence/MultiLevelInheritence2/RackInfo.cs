namespace MultiLevelInheritence2
{
    public class RackInfo:DepartmentDetails
    {

        public int RackNumber { get; set; }
        public int  ColumnNumber { get; set; }
        public RackInfo(string departmentName,string degree,int rackNumber,int columnNumber):base(departmentName,degree)
        {
            RackNumber=rackNumber;
            ColumnNumber=columnNumber;
        }

    }
}