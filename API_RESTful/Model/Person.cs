using API_RESTful.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_RESTful.Model
{
    [Table("person")]
    public class Person : BaseEntity
    {

        [Column("first_name")]
        public string firstName { get; set; }
        [Column("last_name")]
        public int lastName { get; set; }
        [Column("age")]
        public int Age { get; set; }
        [Column("gender")]
        public string Gender { get; set; }
    }
}
