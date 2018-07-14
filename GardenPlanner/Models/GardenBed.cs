using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenPlanner.Models
{
    public class GardenBed
    {
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public int HoursOfSun { get; set; }
        public bool IsIndoors { get; set; }


        //Method that determines how many of said plant can fit into a garden bed

        public int HowManyPlantsInThisBed(Vegetable vegetable)
        {
            decimal vegetableArea = (vegetable.SpaceBetween * 2m);
            decimal gardenbedArea = (Length * Width);
            int result = Convert.ToInt32(gardenbedArea / vegetableArea);

            return result;
        }
    }

}
