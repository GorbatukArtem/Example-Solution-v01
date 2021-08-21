using Database.Models.Content.OrgStructures;

namespace Database.Models.Content.OrgPositions
{
    public class Document
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public int PositionId { get; set; }

        public Position Position { get; set; }
    }
}