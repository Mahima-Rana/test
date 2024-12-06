using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracker.Models
{
    public class WorkoutViewModel
    {
        public int workoutmasterid { get; set; }
        public int bmi_low {get; set;}
        public int bmi_high { get; set; }
        public string workout_name { get; set; }
        public string descp { get; set; }


    }
}
