using System.Collections.Generic;

namespace SAGRHA.API.Models
{
    public class RelationTypeCatalog
    {

        public int Id { get; set; }
        public string RelationType { get; set; }
        public ICollection<Relative> Relatives { get; set; }

    }
}