using API_RESTful.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_RESTful.Repository
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        T Create(T item);
        List<T> FindAll();
        T FindById(int id);
        T Update(T item);
        void Delete(int id);

    }
}
