using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GenericsOOP
{
    public class GenericList<T>
    {
        private T[] storage;
        private int counter = 0;
        private int capacity = 0;

        public T[] Storage { get { return this.storage; } }
        public int CurrentIndex { get { return this.counter; } }

        public GenericList(int capacity = 1)
        {
            this.capacity = capacity;
            this.storage = new T[capacity];
        }

        public void Add(T item)
        {
            if (capacity == counter)
                IncreaseStorage();
            this.storage[counter] = item;
            counter++;
        }

        public T[] RemoveAt(T[] arr, int index)
        {
            for (int a = index; a < arr.Length - 1; a++)
            {
                // moving elements downwards, to fill the gap at [index]
                arr[a] = arr[a + 1];
            }
            // finally, let's decrement Array's size by one
            Array.Resize(ref arr, arr.Length - 1);
            return arr;
        }

        public void Clear()
        {
            this.storage = new T[1];
            this.counter = 0;
        }

        public int Count
        {
            get
            {
                return this.storage.Length;
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (this.counter > 0)
                for (int i = 0; i < this.counter; i++)
                {
                    stringBuilder.AppendLine(this.storage[i].ToString());
                }
            else
                stringBuilder.AppendLine("No Path Points existing...");
            return stringBuilder.ToString();
        }

        private void IncreaseStorage()
        {
            var foo = new T[capacity * 2];
            capacity = capacity * 2;
            Array.Copy(storage, foo, storage.Length);
            storage = foo;
        }
    }
}