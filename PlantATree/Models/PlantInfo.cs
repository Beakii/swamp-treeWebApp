using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantATree.Models
{
    public class PlantInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string MaintReq { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
        public SoilDrain SoilDrain { get; set; }
        public Sun Sun { get; set; }
        public int MaxHeight { get; set; }
        public GrowthRate GrowthRate { get; set; }
        public bool Valid { get; set; }
    }
}
