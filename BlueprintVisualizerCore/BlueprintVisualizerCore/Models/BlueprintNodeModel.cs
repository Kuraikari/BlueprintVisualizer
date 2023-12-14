using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BlueprintVisualizerCore.Models
{
    [PrimaryKey("NodeId")]
    public class BlueprintNodeModel
    {
        [NotNull]
        public string NodeId { get; set; } = Guid.NewGuid().ToString();
        [MaxLength(70)]
        public string? Label { get; set; }
        public string Color { get; set; } = "#000000";
        public BlueprintNodeTypeModel NodeType { get; set; } = new BlueprintNodeTypeModel();
        public IList<BlueprintNodePinModel> PinsIn { get; set; } = new List<BlueprintNodePinModel>();
        public IList<BlueprintNodePinModel> PinsOut { get; set; } = new List<BlueprintNodePinModel>();
        public IList<BlueprintNodeModel> Connections { get; set; } = new List<BlueprintNodeModel>();
    }
}
