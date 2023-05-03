using Entities.Concrete.Base;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class School : AuditableEntity
    {
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }

        public Province? Province { get; set; }
        public District? District { get; set; }
        public Neighbourhood? Neighbourhood { get; set; }
        public ICollection<Department>? Departments { get; set; }
        public ICollection<Branch>? Branches { get; set; }
        public ICollection<Classroom>? Classrooms { get; set; }
        public ICollection<Student>? Students { get; set; }
        public ICollection<Lesson>? Lessons { get; set; }
        public ICollection<Teacher>? Teachers { get; set; }
    }
}
