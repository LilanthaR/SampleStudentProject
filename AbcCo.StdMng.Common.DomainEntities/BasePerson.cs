using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcCo.StdMng.Common.DomainEntities
{
    public abstract class BasePerson : BaseEntity
    {
        [StringLength(3)]
        public string Prefix { get; set; }
        [StringLength(20)]
        public string FirstName { get; set; }
        [StringLength(20)]
        public string MiddleName { get; set; }
        [StringLength(20)]
        public string lastName { get; set; }
        [StringLength(200)]
        public string Address { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DOB { get; set; }

        [NotMapped]
        public int Age { get { return (DateTime.Now.Year - DOB.Year); } }

        [NotMapped]
        public string FullName { get { return String.Format("{0} {1} {2} {3}", Prefix, FirstName, MiddleName, lastName); } }

    }
}
