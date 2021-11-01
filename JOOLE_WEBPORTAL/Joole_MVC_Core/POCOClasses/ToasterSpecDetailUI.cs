using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joole_MVC_Core.POCOClasses
{
    public class ToasterSpecDetailUI
    {
        public int ProductID { get; set; }
        public int NumOfPrograms { get; set; }
        public int PowerWattsMax { get; set; }
        public int PowerWattsMin { get; set; }
        public int OperatingVoltageMax { get; set; }
        public int OperatingVoltageMin { get; set; }
        public int HeatMax { get; set; }
        public int HeatMin { get; set; }
        public int OutputPerHour { get; set; }
        public int SlotWidth { get; set; }
        public int ToasterHeight { get; set; }
        public int ToasterWeight { get; set; }
        public string Slot { get; set; }
    }
}
