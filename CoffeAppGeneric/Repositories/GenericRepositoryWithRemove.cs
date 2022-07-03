using CoffeeAppGeneric.Entities;

namespace CoffeeAppGeneric.Repositories
{
    /// <summary>
    /// inheritance from Generic class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericRepositoryWithRemove<T, TKey>:ListRepository<T, TKey> where T:EntityBase
    {
        public void Remove(T item)
        {
            _items.Remove(item);
        }
    }
}
