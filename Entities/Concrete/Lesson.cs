using Entities.Concrete.Base;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Lesson : AuditableEntity
    {
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public int DURATION { get; set; }

        public School School { get; set; }
        public Department Department { get; set; }
        public Branch Branch { get; set; }
        public Classroom Classroom { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
