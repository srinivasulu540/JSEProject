using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.DataAccess.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
    }
}
