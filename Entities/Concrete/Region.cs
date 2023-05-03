using Entities.Concrete.Base;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Region : AuditableEntity
    {
        public string CODE { get; set; }
        public string NAME { get; set; }

        public ICollection<Province> Provinces { get; set; }
    }
}
