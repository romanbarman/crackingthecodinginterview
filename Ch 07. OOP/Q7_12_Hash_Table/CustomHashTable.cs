using System;
using System.Collections;
using System.Collections.Generic;

namespace Chapter07.HashTable
{
    public class CustomHashTable<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    {
        private class HashTableCell
        {
            public TKey Key { get; }
            public TValue Value { get; set; }

            public HashTableCell(TKey key, TValue value)
            {
                Key = key;
                Value = value;
            }
        }

        private LinkedList<HashTableCell>[] array;
        private int length = 0;

        public CustomHashTable()
        {
            array = new LinkedList<HashTableCell>[20];
        }

        public CustomHashTable(int capacity)
        {
            array = new LinkedList<HashTableCell>[capacity];
        }

        public int Length => length;

        public void Add(TKey key, TValue value)
        {
            var (index, cell) = GetCellInfo(key);

            if (cell == null)
            {
                if (array[index] == null)
                {
                    array[index] = new LinkedList<HashTableCell>();
                }

                array[index].AddLast(new LinkedListNode<HashTableCell>(new HashTableCell(key, value)));
                length++;
            }
            else
            {
                cell.Value = value;
            }
        }

        public bool Conatins(TKey key)
        {
            return GetCellInfo(key).cell != null ? true : false;
        }

        public void Remove(TKey key)
        {
            var (index, cell) = GetCellInfo(key);

            if (cell == null)
            {
                return;
            }

            array[index].Remove(cell);
        }

        public TValue this[TKey key]
        {
            get
            {
                var (_, cell) = GetCellInfo(key);
                
                if (cell == null)
                {
                    throw new IndexOutOfRangeException();
                }

                return cell.Value;
            }
        }

        private int GetIndex(TKey key)
        {
            return Math.Abs(key.GetHashCode()) % array.Length;
        }

        private (int index, HashTableCell cell) GetCellInfo(TKey key)
        {
            var index = GetIndex(key);

            if (array[index] == null)
            {
                return (index, null);
            }

            foreach (var item in array[index])
            {
                if (item.Key.Equals(key))
                {
                    return (index, item);
                }
            }

            return (index, null);
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != null)
                {
                    foreach (var item in array[i])
                    {
                        yield return new KeyValuePair<TKey, TValue>(item.Key, item.Value);
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
