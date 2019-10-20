using System;

namespace SAGRHA.API.Dtos
{
    public class RelativeToReturnDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Dni { get; set; }
        public string Relationship { get; set; }
        public int RelationTypeCatalogId { get; set; }
    }
}