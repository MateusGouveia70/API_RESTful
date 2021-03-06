using API_RESTful.HiperMedia;
using API_RESTful.HiperMedia.Abstract;
using API_RESTful.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_RESTful.Data.VO
{
    public class PersonVO : ISupportHypeMedia
    {
        public int Id { get; set; }
        public string firstName { get; set; }        
        public string lastName { get; set; }       
        public int Age { get; set; }       
        public string Gender { get; set; }
        public List<HyperMediaLink> Links { get ; set; } = new List<HyperMediaLink>();
    }
}
