using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace kursova.Data
{
    public class DbSet<T> : IEnumerable<T> where T : class
    {
        private List<T> _data = new List<T>();

        public void Add(T entity)
        {
            _data.Add(entity);
        }

        public void Remove(T entity)
        {
            _data.Remove(entity);
        }

        public IEnumerable<T> ToList()
        {
            return _data.ToList();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        public T FirstOrDefault(Func<T,bool> predicate)
        {
            return _data.FirstOrDefault(predicate);
        }

        public int Count()
        {
            return _data.Count;
        }
    }
}
