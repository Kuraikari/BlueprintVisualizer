using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BlueprintVisualizerCore.Models
{
    [PrimaryKey("PinId")]
    public class BlueprintNodePinModel
    {
        [NotNull]
        public string PinId { get; set; } = Guid.NewGuid().ToString();
        [MaxLength(24)]
        public string Label { get; set; } = "execute";
        public bool IsInput { get; set; } = true;
    }
}
