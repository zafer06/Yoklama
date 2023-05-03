using Entities.Concrete.Base;

namespace Entities.Concrete
{
    public class User : AuditableEntity
    {
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }

        public Person Person { get; set; }
    }
}
