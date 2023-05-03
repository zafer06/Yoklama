using Entities.Concrete.Base;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Department : AuditableEntity
    {
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }

        public School School { get; set; }
        public ICollection<Branch> Branches { get; set; }
    }
}
