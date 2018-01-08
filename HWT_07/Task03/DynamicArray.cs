namespace Task03
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class DynamicArray<T> : IEnumerator, IEnumerable
    {
        private T[] array;
        private int arraySize = 8;
        private int index = -1;

        public DynamicArray()
        {
            array = new T[arraySize];
        }

        public DynamicArray(int arrayCapacity)
        {
            array = new T[arrayCapacity];
            arraySize = arrayCapacity;
        }

        public DynamicArray(IEnumerable<T> value)
        {
            array = new T[value.Count()];
            for (int i = 0; i < value.Count(); i++)
            {
                array[i] = value.ToArray()[i];
            }

            arraySize = value.Count();
        }

        public int Lenght
        {
            get { return arraySize; }
        }

        public int Capacity
        {
            get
            {
                int count = 0;
                for (int i = 0; i < arraySize; i++)
                {
                    if (array[i].ToString() != "0")
                    {
                        count++;
                    }
                }

                return count;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index > arraySize - 1)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return array[index];
            }

            set
            {
                array[index] = value;
            }
        }

        public object Current
        {
            get { return array[index]; }
        }

        public bool MoveNext()
        {
            if (index == arraySize - 1)
            {
                Reset();
                return false;
            }

            index++;
            return true;
        }

        public void Reset()
        {
            index = -1;
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public void Add(T element)
        {
            int flag = 0;

            for (int i = 0; i < arraySize; i++)
            {
                if (array[i].ToString() == "0" & flag == 0)
                {
                    array[i] = element;
                    flag = 1;
                }

                if (array[array.Length - 1].ToString() != "0")
                {
                    DoubleArraySize();
                }
            }
        }

        public void AddRange(IEnumerable<T> value)
        {
            int index = 3;
            int flag = 0;
            T[] arrayTemp = new T[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                if (array[i].ToString() == "0" & flag == 0)
                {
                    index = i;
                    flag = 1;
                }
            }

            if (value.Count() == arraySize - index)
            {
                foreach (var a in value)
                {
                    array[index] = a;
                    index++;
                } 
            }

            if (value.Count() > arraySize - index)
            {
                for (int i = 0; i < arraySize; i++)
                {
                    arrayTemp[i] = array[i];
                }

                arraySize = index + value.Count();
                array = new T[arraySize];

                for (int i = 0; i < index; i++)
                {
                    array[i] = arrayTemp[i];
                }

                foreach (var a in value)
                {
                    array[index] = a;
                    index++;
                }
            }
        }

        public bool Remove(int index)
        {
            T[] arrayTemp = new T[arraySize];
            T[] arrayTemp2 = new T[arraySize];

            if (index > (arraySize - 1))
            {
                return false;
            }

            if (index <= arraySize)
            {
                for (int i = 0; i < arraySize - (index + 1); i++)
                {
                    arrayTemp[i] = array[i + index + 1];
                }

                for (int i = index; i < arraySize; i++)
                {
                    array[i] = arrayTemp2[i];
                }

                for (int i = 0; i < arraySize - (index + 1); i++)
                {
                    array[i + index] = arrayTemp[i];
                }        
            }

            return true;
        }

        public bool Insert(int index, T item)
        {
            if (index > (arraySize - 1))
            {
                return false;
                throw new ArgumentOutOfRangeException();
            }

            if (index < arraySize)
            {
                if ((array[arraySize - 1].ToString() != "0") | (index == (arraySize - 1)))
                {
                    DoubleArraySize();
                }

                T[] arrayTemp = new T[arraySize];

                for (int i = index; i < arraySize; i++)
                {
                    arrayTemp[i] = array[i];
                }

                for (int i = 0; i < index + 1; i++)
                {  
                    if (i == index)
                    {
                        array[i] = item;
                    }
                }

                for (int i = index; i < (arraySize - index - 1); i++)
                {
                    array[i + 1] = arrayTemp[i];
                }
            }

            return true;
        }

        private void DoubleSize()
        {
            arraySize *= 2;
        }

        private void DoubleArraySize()
        {
            T[] arrayTemp = new T[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                arrayTemp[i] = array[i];
            }

            DoubleSize();

            array = new T[arraySize];
            for (int i = 0; i < arraySize / 2; i++)
            {
                array[i] = arrayTemp[i];
            }
        }
    }
}
