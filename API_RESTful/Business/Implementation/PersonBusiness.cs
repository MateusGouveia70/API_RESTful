using API_RESTful.Data.Converter.Implementation;
using API_RESTful.Data.VO;
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

        private readonly PersonConverter _converter;


        public PersonBusiness(IGenericRepository<Person> reposiroty)
        {
            _repository = reposiroty;
            _converter = new PersonConverter();
        }

        public PersonVO Create(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Create(personEntity);
            return _converter.Parse(personEntity);

        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<PersonVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public PersonVO FindById(int id)
        {
            return  _converter.Parse(_repository.FindById(id));
           
        }

        public PersonVO Update(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }
    }
}
