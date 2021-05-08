using API_RESTful.Model;
using API_RESTful.Model.MyContext;
using API_RESTful.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_RESTful.Business.Implementation
{
    public class PersonBusiness : IPersonbusiness
    {
        private IGenericRepository<Person> _repository;


        public PersonBusiness(IGenericRepository<Person> reposiroty)
        {
            _repository = reposiroty;
        }

        public Person Create(Person person)
        {

            return _repository.Create(person);

        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person FindById(int id)
        {
            return _repository.FindById(id);
        } 

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }
    }
}
