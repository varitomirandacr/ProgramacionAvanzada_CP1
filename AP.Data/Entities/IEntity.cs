using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP.Data.Entities
{
    public interface IEntity
    {
        string UniqueIdentifier { set; get; }
    }
}
