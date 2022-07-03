namespace CoffeeAppGeneric.Repositories
{
    public interface ISqlWriteRepository<in T>
    {
        void Add(T item);

        void Remove(T item);

        void Save();
    }
}