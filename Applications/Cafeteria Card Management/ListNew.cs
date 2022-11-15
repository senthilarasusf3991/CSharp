using System.Collections;
namespace CafeteriaCardManagement
{
    public partial class List<Type>:IEnumerable,IEnumerator
    {
        int i;
        public IEnumerator GetEnumerator()
        {
            i=-1;
            return (IEnumerator)this;
        }
        public bool MoveNext()
        {
            if(i<_count-1)
            {
                ++i;
                return true;

            }Reset();//Resetting the positiom values ...if no element is present in the list
            return false;
        }
        public void Reset() //For the next turn resetting i
        {
            {i=-1; }
        }
        public object Current //To Return the position value of the Current Array
        {
            get { return _array[i]; }
        }
    }
}