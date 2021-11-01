using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joole_MVC_Core.POCOClasses
{
    public class FanSpecDetailUI
    {
        public int ProductID { get; set; }
        public int AirFlowCFM { get; set; }
        public int PowerWattsMax { get; set; }
        public int PowerWattsMin { get; set; }
        public int OperatingVoltageMax { get; set; }
        public int OperatingVoltageMin { get; set; }
        public int FanSpeedMax { get; set; }
        public int FanSpeedMin { get; set; }
        public int NumbSpeed { get; set; }
        public int MaxSound { get; set; }
        public int SweepDiameter { get; set; }
        public int FanWeight { get; set; }
        public string MountingLocation { get; set; }
    }
}
