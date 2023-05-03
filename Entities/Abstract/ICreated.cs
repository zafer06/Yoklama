using System;

namespace Entities.Abstract
{
    public interface ICreated
    {
        public long CREATEDBY { get; set; }
        public DateTime CREATIONDATE { get; set; }
    }
}
