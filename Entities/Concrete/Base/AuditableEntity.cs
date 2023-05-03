using Entities.Abstract;
using System;

namespace Entities.Concrete.Base
{
    public class AuditableEntity : Entity, IAuditable
    {
        public long CREATEDBY { get; set; }
        public DateTime CREATIONDATE { get; set; }
        public long? MODIFIEDBY { get; set; }
        public DateTime? MODIFICATIONDATE { get; set; }
    }
}
