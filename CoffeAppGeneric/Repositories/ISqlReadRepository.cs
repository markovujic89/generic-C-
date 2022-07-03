using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeAppGeneric.Entities;

namespace CoffeeAppGeneric.Repositories
{
    /// <summary>
    /// Covariant type of parameter
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISqlReadRepository<out T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
