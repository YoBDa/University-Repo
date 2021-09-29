using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ProjectSET
{
    public class ItemNotFoundException : Exception
    {
        public ItemNotFoundException(string message)
            : base(message)
        { }
    }
    public class RemoveFromEmptySetException : Exception
    {
        public RemoveFromEmptySetException(string message)
            : base(message)
        { }
    }
    public class AddRemoveNullElementException : Exception
    {
        public AddRemoveNullElementException(string message)
            : base(message)
        { }
    }
    /// <summary>
    /// Class <c>MySet</c> represents set.
    /// </summary>
    public class MySet<T> : IEnumerable<T> where T : IComparable
    {
        private List<T> items = new List<T>(); // container
        public int Count // Property of count
        {
            get { return items.Count; } // redirection of container's property
        }

        public void Add(T value) // Adding item in set
        {
            if (value == null) throw new AddRemoveNullElementException("Attemt adding null item");
            if (!items.Contains(value)) // if set not contains it
                items.Add(value);
        }
        public void Add(MySet<T> Set)
        {
            foreach (var item in Set)
                this.Add(item);
        }
        public void Remove(T value) // remove item from set
        {
            if (value==null) throw new AddRemoveNullElementException("Attemt removing null item");
            if (items.Count == 0) throw new RemoveFromEmptySetException("Attempt removing from empty set."); //throw exception if set is empty
            if (!items.Remove(value)) throw new ItemNotFoundException("Attempt removing item which not exist"); //remove, if can't throw exception
        }
        public static MySet<T> Union(MySet<T> set1, MySet<T> set2) // Union of sets
        {
            MySet<T> res = new MySet<T>();
            
            if (set1.Count != 0) // if set isn't empty  add it to result set
                foreach (var item in set1)
                    res.Add(item);
            if (set2.Count != 0) // second stage
                foreach (var item in set2)
                    res.Add(item);
            return res;
        }
        public static MySet<T> Intersection(MySet<T> set1, MySet<T> set2) // intersections of sets
        {
            MySet<T> res = new MySet<T>();

            if (set1.Count == 0 || set2.Count == 0) return res; // if one of sets is empty return empty set
            foreach (var item in set1) 
                if (set2.items.Contains(item))  // if item of first set in second set then add it to res
                    res.Add(item);
            return res;
        }
        public static MySet<T> Difference(MySet<T> set1, MySet<T> set2) // Difference of sets A/B
        {
            MySet<T> res = new MySet<T>();
            foreach (var item1 in set1)
                if (!set2.items.Contains(item1)) res.Add(item1); //if item of set1 not in set2 then add it to res
            return res;
        }
        public static bool Subset(MySet<T> set1, MySet<T> set2) // is set1 in set2
        {
            MySet<T> res = new MySet<T>();

            foreach (var item in set1)
                if (!set2.items.Contains(item)) return false; // if every item of set1 is in set2 then return true, otherwise return false
            return true;
        }
        public override string ToString()
        {
            return ToString();
        }
        public string ToString(char delimiter = ',')
        {
            if (this.Count == 0) return "Empty";
            StringBuilder sb = new StringBuilder();
            foreach (var item in this.items)
            {
                sb.Append(delimiter);
                sb.Append(item.ToString());
            }
            return sb.Remove(0, 1).ToString();
        }
        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return items.GetEnumerator();
        }
            
    }
}
