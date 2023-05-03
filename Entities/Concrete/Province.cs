using Entities.Concrete.Base;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Province : AuditableEntity
    {
        public int CODE { get; set; }
        public string NAME { get; set; }

        public Region Region { get; set; }
        public ICollection<District> Districts { get; set; }
    }
}
