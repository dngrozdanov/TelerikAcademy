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

        public void RemoveAt(ref T[] arr, int index)
        {
            for (int a = index; a < arr.Length - 1; a++)
            {
                // moving elements downwards, to fill the gap at [index]
                arr[a] = arr[a + 1];
            }
            // finally, let's decrement Array's size by one
            Array.Resize(ref arr, arr.Length - 1);
        }

        public void Clear()
        {
            this.storage = null;
        }

        public bool ElementExistsByIndex(int index)
        {
            bool exists = false;
            if (this.Count >= index)
                exists = true;
            else
                exists = false;
            return exists;
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
            foreach (var point in this.Storage)
            {
                stringBuilder.AppendLine(point.ToString());
            }
            return stringBuilder.ToString();
        }

        private void IncreaseStorage()
        {
            var foo = new T[++capacity];
            Array.Copy(storage, foo, storage.Length);
            storage = foo;
        }
    }
}