using API_RESTful.Model;
using API_RESTful.Model.MyContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_RESTful.Business.Implementation
{
    public class PersonBusiness : IPersonbusiness
    {
        private MySQLContext _context;

        public PersonBusiness(MySQLContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Person> FindAll()
        {
            return _context.persons.ToList();
        }

        public Person FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Person Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
