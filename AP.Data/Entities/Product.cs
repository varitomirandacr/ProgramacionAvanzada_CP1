using AP.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP.Data
{
    public partial class Product : IEntity
    {
        [NotMapped]
        public string UniqueIdentifier { get; set; }
    }
}
