using System.Collections;
using System.Collections.Generic;
using CoffeeAppGeneric.Entities;

namespace CoffeeAppGeneric.Repositories
{
    public interface ISqlRepository<T>:ISqlReadRepository<T>, ISqlWriteRepository<T> where T : IEntityBase
    {
        
        
        
        
    }
}