using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracker.Models
{
    public class LoginViewModel
    {
        public int userid { get; set; }
        public string username { get; set; }
        public int password { get; set; }
        public string disp_name { get; set; }
        public int phno { get; set; }
    }
}
