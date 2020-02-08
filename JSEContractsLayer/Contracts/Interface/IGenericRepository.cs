using System;
using System.Collections.Generic;
using System.Text;

namespace JSEContractsLayer.Contracts.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        //IEnumerable<T> GetAll();
        //T GetById(object Id);
        T Insert(T obj);
        //void Delete(object Id);
        //T Update(T obj);
        //void Save();
    }
}
