using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsOOP
{
    public class GenericList<T>
    {
        private List<T> storage;

        public List<T> Storage { get => new List<T>(storage); }

        public GenericList(int capacity = 5)
        {
            this.storage = new List<T>(capacity);
        }

        public void Add(T item)
        {
            this.storage.Add(item);
        }

        public void Remove(T item)
        {
            if (Exists(item))
                this.storage.Remove(item);
        }

        public void Remove(int index)
        {
            if (ElementExistsByIndex(index))
                this.storage.RemoveAt(index);
        }

        public void Insert(T item, int position = 0)
        {
            this.storage.Insert(position, item);
        }

        public void Clear()
        {
            this.storage.Clear();
        }

        public int IndexOf(T item)
        {
            return this.storage.IndexOf(item);
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

        public bool Exists(T item)
        {
            return this.storage.Exists(x => x.Equals(item));
        }

        public int Count
        {
            get
            {
                return this.storage.Count;
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
    }
}