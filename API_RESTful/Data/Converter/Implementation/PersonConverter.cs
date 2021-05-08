using API_RESTful.Data.VO;
using API_RESTful.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_RESTful.Data.Converter.Implementation
{
    public class PersonConverter : IParser<PersonVO, Person>, IParser<Person, PersonVO>
    {

        public Person Parse(PersonVO origin)
        {
            if (origin == null) return null;
            return new Person
            {
                Id = origin.Id,
                firstName = origin.firstName,
                lastName = origin.lastName,
                Age = origin.Age,
                Gender = origin.Gender
            };
        }

        public PersonVO Parse(Person origin)
        {
            if (origin == null) return null;
            return new PersonVO
            {
                Id = origin.Id,
                firstName = origin.firstName,
                lastName = origin.lastName,
                Age = origin.Age,
                Gender = origin.Gender
            };
        }

        public List<Person> Parse(List<PersonVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(p => Parse(p)).ToList();
        }

        public List<PersonVO> Parse(List<Person> origin)
        {
            if (origin == null) return null;
            return origin.Select(p => Parse(p)).ToList();
        }
    }

}
