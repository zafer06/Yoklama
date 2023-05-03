using Entities.Concrete.Base;

namespace Entities.Concrete
{
    public class Neighbourhood : AuditableEntity
    {
        public string CODE { get; set; }
        public string NAME { get; set; }

        public District District { get; set; }
    }
}
