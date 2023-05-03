using Entities.Concrete.Base;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Teacher : AuditableEntity
    {
        public Person? Person { get; set; }
        public Department? Department { get; set; }
        public Branch? Branch { get; set; }
        public Classroom? Classroom { get; set; }
        public ICollection<School>? Schools { get; set; }
    }
}
