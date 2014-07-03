using System;
using System.Text;
using System.Linq;

namespace Defining_Classes_Part_II
{
    class GenericList<T>
    {
        private T[] array;
        private int count = 0;
        private int capacity = 0;
        private int startCapacity = 0;

        public GenericList (int capacity)
        {
            this.array = new T[capacity];
            this.capacity = capacity;
            this.startCapacity = capacity;
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
        }

        public int Count
        {
            get 
            {
                return this.count;
            }
        }

        private void DoubleCapacity ()
        {
            T[] tempArray = new T[array.Length * 2];
            this.capacity = tempArray.Length;

            Array.Copy (array, tempArray, array.Length);
            array = tempArray;

        }

        private void DecreaseCapacity ()
        {
            if (this.capacity < 8)
            {
                return;
            }
            T[] tempArray = new T[array.Length / 2];
            this.capacity = tempArray.Length;

            Array.Copy (array, tempArray, this.count);
            array = tempArray;
        }

        public void Add (T element)
        {
            if (this.count >= this.capacity - 1)
            {
                DoubleCapacity ();
            }

            this.array[count] = element;
            this.count++;
        }

        public T GetElement (int index)
        {
            if (index < 0 || index >= this.count)
            {
                throw new IndexOutOfRangeException ("Index is out of range !");
            }

            return array[index];
        }

        public void InsertElementAtIndex (int index, T element)
        {
            if (index < 0 || index >= this.count)
            {
                throw new IndexOutOfRangeException ("Index is out of range !"); 
            }

            if (this.count >= this.capacity - 1)
            {
                DoubleCapacity ();
            }
            
            Array.Copy (array, index, array, index + 1, array.Length - index - 1);
            array[index] = element;

            this.count++;
        }

        public void RemoveElementAtIndex (int index)
        {           
            if (index < 0 || index >= this.count)
            {
                throw new IndexOutOfRangeException ("Index is out of range !");
            }

            Array.Copy (array, index + 1, array, index, array.Length - index - 1);

            this.count--;

            if (this.count < this.capacity / 2)
            {
                DecreaseCapacity ();
            }
        }

        public void Clear ()
        {
            this.array = new T[this.startCapacity];
            this.capacity = this.startCapacity;
            this.count = 0;
        }

        public int FindByValue (T element)
        {
            int index = Array.IndexOf (array, element);

            return index; 
        }

        public override string ToString ()
        {
            StringBuilder sb = new StringBuilder ();
            for (int i = 0; i < this.count; i++)
            {
                sb.AppendFormat ("{0}, ", array.GetValue(i).ToString());
            }

            string trueString = sb.Remove (sb.Length - 2, 2).ToString ();
            return trueString;
        }

        public T Min<T> () where T : IComparable<T>, IComparable
        {
            dynamic min = array.Min ();

            return min;
        }

        public T Max<T> () where T : IComparable<T>, IComparable
        {
            dynamic max = array.Max ();

            return max;
        }
    }
}
