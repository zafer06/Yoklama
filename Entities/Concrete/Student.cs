using Entities.Concrete.Base;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Student : AuditableEntity
    {
        public Person Person { get; set; }
        public School School { get; set; }
        public Department Department { get; set; }
        public Branch Branch { get; set; }
        public Classroom Classroom { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
    }
}
