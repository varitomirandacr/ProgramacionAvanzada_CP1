using AP.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace AP.Data
{
    public partial class Supplier : IEntity
    {
        [NotMapped]
        public string UniqueIdentifier { get; set; }
    }
}
