using CoffeeAppGeneric.Entities;
using CoffeeAppGeneric.Repositories;

namespace CoffeeAppGeneric.Extensions
{
    /// <summary>
    /// Extension class
    /// </summary>
    public static class RepositoryExtension
    {
        /// <summary>
        /// With this keyword, I made that AddBatch represent extension method of ISqlRepository,
        /// than I can call AddBatch in Program.cs from SQLRepository instance
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="repository"></param>
        /// <param name="items"></param>
        public static void AddBatch<T>(this ISqlRepository<T> repository, T[] items) where T : IEntityBase
        {
            foreach (var item in items)
            {
                repository.Add(item);
            }
            repository.Save();
        }
    }
}
