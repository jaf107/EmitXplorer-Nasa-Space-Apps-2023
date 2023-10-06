using System.ComponentModel.DataAnnotations;

namespace Backend_EXP.Models
{
    public class Tree
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }
        public string SoilType { get; set; }
        public int MinHeight { get; set; }
        public int MaxHeight { get; set; }
        public string CO2AbsorptionRate { get; set; }
        public string CH2AbsorptionRate { get; set; }
        public string ScientificName { get; set; }

    }
}
