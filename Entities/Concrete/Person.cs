using Entities.Concrete.Base;
using Entities.Enums;

namespace Entities.Concrete
{
    public class Person : AuditableEntity
    {
        public long MERNISNO { get; set; }
        public string NAME { get; set; }
        public string SURNAME { get; set; }
        public Gender GENDER { get; set; }
        public long MOBILEPHONE { get; set; }
        public string EMAIL { get; set; }
        public string ADDRESS { get; set; }

        public Province? Province { get; set; }
        public District? District { get; set; }
        public Neighbourhood? Neighbourhood { get; set; }
    }
}
