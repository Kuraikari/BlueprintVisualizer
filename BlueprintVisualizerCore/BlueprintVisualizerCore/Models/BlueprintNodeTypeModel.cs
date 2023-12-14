using Microsoft.EntityFrameworkCore;

namespace BlueprintVisualizerCore.Models
{
    [PrimaryKey("Id")]
    public class BlueprintNodeTypeModel
    {
        public int Id { get; set; }
        public string TypeName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
