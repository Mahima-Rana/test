using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracker.Models
{
    public class HealthViewModel
    {
        public int healthid { get; set; }
        public int userid { get; set; }
        public int height {  get; set; }
        public int weight { get; set; }
        public int bmi {  get; set; }
    }
}
