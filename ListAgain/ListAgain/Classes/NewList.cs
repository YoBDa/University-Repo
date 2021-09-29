using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace ListAgain.Classes
{
    public class NewList : IEnumerable<int>
    {
        private List<int> InternalList;
        public DataTable DataTable;

        public delegate void OnStateChange();
        public event OnStateChange StateChanged;
       
        public NewList()
        {
            InternalList = new List<int>();
           
        }
        public int Count { get => InternalList.Count; }
        private void StateChangedInvoker()
        {
            StateChanged?.Invoke();
        }
        public void Add(int Value)
        {
            InternalList.Add(Value);
            StateChangedInvoker();
        }
        public void AddAt(int Value, int Index)
        {
            if (Index < 0) return;
            if (Index >= InternalList.Count)
            {
                Add(Value);
                StateChangedInvoker();
                return;
            }

            InternalList.Insert(Index, Value);
            StateChangedInvoker();

        }
       
        public void RemoveAt(int Index)
        {
            if (Index < 0) return;
            if (InternalList.Count > Index)
            {
                InternalList.RemoveAt(Index);
                StateChangedInvoker();
            }
        }
        public void Clear()
        {
            InternalList.Clear();
            StateChangedInvoker();
        }
        public void Sort()
        {
            InternalList.Sort();
            StateChangedInvoker();
        }

        public IEnumerator<int> GetEnumerator()
        {
            return ((IEnumerable<int>)InternalList).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)InternalList).GetEnumerator();
        }

        public int this[int index]
        {
            get { return InternalList[index]; }

        }
    }
}
