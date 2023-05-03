using System;

namespace Entities.Abstract
{
    public interface IUpdated
    {
        public long? MODIFIEDBY { get; set; }
        public DateTime? MODIFICATIONDATE { get; set; }
    }
}
