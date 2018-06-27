using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenPlanner.Models
{
    class Plant
    {
        public string LightType { get; set; }
        public int heightMin { get; set; }
        public int heightMax { get; set; }
        public int widthMin { get; set; }
        public int widthMax { get; set; }
        public string HarvestTips { get; set; }
        public string Description { get; set; }
        public bool Determinate { get; set; }
        //determinate plants grow all season, continuing to bloom and produce fruit 
        //as long as weather conditions are favorable. Determinate plants grow to a certain size, set fruit, and stop growing
    }
}
