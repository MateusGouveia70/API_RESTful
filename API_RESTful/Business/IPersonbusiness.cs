using API_RESTful.Data.VO;
using API_RESTful.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_RESTful.Business
{
    public interface IPersonbusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindById(int id);
        List<PersonVO> FindAll();
        PersonVO Update(PersonVO person);
        void Delete(int id);
    }
}
