
namespace DictionaryDS
{
    public partial class Dictionary<TKey,TValue>
    {
        private int _count;
        private int _capacity;
        public int Count{get {return _count;}}
        public int Capacity{get {return _capacity;}}
        public KeyValuePair<TKey,TValue>[] _array;
        public TValue this[TKey key]
        {
            get
            {
                int position=SearchKey(key);
                if(position>-1)
                {
                    return _array[position].value;
                }
                else
                {
                    return default(TValue);
                }
            }
            set
            {
                int position=SearchKey(key);
                {
                    if(position>=0)
                    {
                        _array[position].value=value;
                    }
                }
            }
        }
        public Dictionary()
        {
            _count=0;
            _capacity=4;
            _array=new KeyValuePair<TKey, TValue>[_capacity];

        }
        public Dictionary(int size)
        {
            _count=0;
            _capacity=size;
            _array=new KeyValuePair<TKey, TValue>[_capacity];
        }
        public void Add(TKey key,TValue value)
        {
            if(SearchKey(key)>=0)
            {
                System.Console.WriteLine("Duplicate Key");
            }
            else{
                KeyValuePair<TKey,TValue> obj = new KeyValuePair<TKey, TValue>(){Key=key,value=value};
                if(_count==_capacity)
                {
                    GrowSize();
                }
                _array[_count]=obj;
                _count++;
            }

        }
        public void GrowSize()
        {
            _capacity=_capacity*2;
        }
        private int SearchKey(TKey key)
        {
            for(int i=0;i<_count;i++)
            {
                if(_array[i].Key.Equals(key))
                {
                    return i;
                }
            }
            return-1;
        }
        private int SearchValue(TValue value)
        {
            for(int i=0; i<_count;i++)
            {
                if(_array[i].value.Equals(value))
                {
                    return i;
                }
            }
            return-1;
        }
        public bool ContainsKey(TKey key)
        {
            if(SearchKey(key)>=0)
            {
                return true;
            }
            return false;
        }
        public bool ContainsValue(TValue value)
        {
            if(SearchValue(value)>=0)
            {
                return true;
            }
            return false;
        }
        public void Remove(TKey key)
        {
            int temp=SearchKey(key);
            if(temp>=0)
            {
                for (int i=temp;i<_count-1;i++)
                {
                    _array[i]=_array[i+1];
                }
                _count--;
            }
        }




    }
}