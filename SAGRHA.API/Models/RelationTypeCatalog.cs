namespace SAGRHA.API.Models
{
    public class RelationTypeCatalog
    {
        public int Id { get; set; }
        public string RelationType { get; set; }
        public string Description { get; set; }
        public Relative Relative { get; set; }
        public int RelativeId { get; set; }

    }
}