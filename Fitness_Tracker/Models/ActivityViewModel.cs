using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracker.Models
{
    public class ActivityViewModel
    {
        public int activityid { get; set; }
        public int workoutmasterid { get; set; }
        public string exercise { get; set; }
        public int reps { get; set; }
        public int durations { get; set; }
    }
}
