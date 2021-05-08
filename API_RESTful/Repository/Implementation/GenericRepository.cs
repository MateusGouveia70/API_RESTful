using API_RESTful.Model.Base;
using API_RESTful.Model.MyContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_RESTful.Repository.Implementation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private MySQLContext _context;

        private DbSet<T> dataset;

        public GenericRepository(MySQLContext context)
        {
            _context = context;
            dataset = _context.Set<T>();
        }



        public List<T> FindAll()
        {
            return dataset.ToList();
        }


        public T FindById(int id)
        {
            return dataset.SingleOrDefault(i => i.Id.Equals(id));
        }


        public T Create(T item)
        {
            try
            {
                dataset.Add(item);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return item;
        }
      

        public T Update(T item)
        {
            var result = dataset.SingleOrDefault(p => p.Id.Equals(item.Id));
            if(result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(item);
                    _context.SaveChanges();
                    return item;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                return null;
            }
        }

        public void Delete(int id)
        {
            var result = dataset.SingleOrDefault(p => p.Id.Equals(id));
            if (result!= null)
            {
                try
                {
                    dataset.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
