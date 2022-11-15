namespace ArrayListDS
{
    public partial class ArrayList
    {    
        
        private int _capacity;
        private int _count;
        public int Capacity{get{return _capacity;}}
        public int Count{get{return _count;}}
        private dynamic[] _array{get;set;}
        public dynamic this [int i]
        {
            get{return _array[i];}
            set{_array[i]=value;}
        }

        public ArrayList()
        {
            _count=0;
            _capacity=4;
            _array=new dynamic[_capacity];
        }
        public ArrayList(int size)
        {
            _count=0;
            _capacity=size;
            _array=new dynamic[_capacity];
        }
        public void Add(dynamic data)
        {
        if(_count==_capacity)
            {
                GrowSize();
            }
            _array[_count]=data;
            _count++;
        }
        public void GrowSize()
        {
            _capacity=_capacity*2;
            Type[] temp=new dynamic[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;
        }
        public void AddRange(ArrayList<Type>dataList)
        {
            dynamic[] temp=new dynamic[_count+dataList.Count];
            for (int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            for (int i=0;i<dataList.Count;i++)
            {
                temp[_count+i]=dataList[i];
                
            }
            _array=temp;
            _count+=dataList.Count;
        }
        
    }
   
}
