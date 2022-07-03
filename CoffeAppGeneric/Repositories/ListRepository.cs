using CoffeeAppGeneric.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeAppGeneric.Repositories
{
    public class ListRepository<T, TKey> where T:class, IEntityBase
    {
        protected readonly List<T> _items;

        /// <summary>
        /// Example for using multiple type parameters for generic classes
        /// </summary>
        public TKey? Key { get; set; }

        public ListRepository()
        {
            _items = new List<T>();
        }

        public void Add(T item)
        {
            _items.Add(item);
        }

        public void Save()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }

        public T GetById(int id)
        {
           return _items.Single(x => x.Id == id);
        }
    }
}
