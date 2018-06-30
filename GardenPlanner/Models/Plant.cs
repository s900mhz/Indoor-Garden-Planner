using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenPlanner.Models
{
    class Vegetable
    {
        public int HeightMin { get; set; }
        public int HeightMax { get; set; }
        public int WidthMin { get; set; }
        public int WidthMax { get; set; }
        public string HarvestTips { get; set; }
        public string Description { get; set; }
        public bool Determinate { get; set; }
        //determinate plants grow all season, continuing to bloom and produce fruit 
        //as long as weather conditions are favorable. Determinate plants grow to a certain size, set fruit, and stop growing
        public enum eFamily
        {
         Cabbage,
         Beet,
         LeafyGreens,
         Herbs,
         Beans,
         Corn,
         Onion,
         Peas,
         Squash,
         Potatoes,
         Tomatos,
        }
        
    }
}
