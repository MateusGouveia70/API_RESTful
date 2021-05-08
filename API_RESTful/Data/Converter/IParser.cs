using API_RESTful.Data.VO;
using API_RESTful.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_RESTful.Data.Converter
{
    public interface IParser<O, D>
    {
        D Parse(O origin);

        List<D> Parse(List<O> origin);


    }
}
