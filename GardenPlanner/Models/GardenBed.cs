using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenPlanner.Models
{
    class GardenBed
    {
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public int HoursOfSun { get; set; }
        public bool IsIndoors { get; set; }
    }
}
