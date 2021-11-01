using Joole_MVC_Core;
using Joole_MVC_Core.POCOClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joole_MVC_Infrastructure.Repository
{
    public class DetailRepository : IDetailRepository
    {
        JooleDataBaseEntities _entities;
        public List<FanSpecDetailUI> GetAllFans()
        {
            _entities = new JooleDataBaseEntities();
            var _lstFanUI = new List<FanSpecDetailUI>();
            var _lstFans = _entities.tblTechSpecsFans.ToList();

            foreach (var fan in _lstFans)
            {
                _lstFanUI.Add(new FanSpecDetailUI
                {   
                    ProductID = fan.ProductID,
                    AirFlowCFM = (int)fan.AirFlowCFM,
                    PowerWattsMax = (int)fan.PowerWattsMax,
                    PowerWattsMin = (int)fan.PowerWattsMin,
                    OperatingVoltageMax = (int)fan.OperatingVoltageMax,
                    OperatingVoltageMin = (int)fan.OperatingVoltageMin,
                    FanSpeedMax = (int)fan.FanSpeedMax,
                    FanSpeedMin = (int)fan.FanSpeedMin,
                    NumbSpeed = (int)fan.NumbSpeed,
                    MaxSound = (int)fan.MaxSound,
                    SweepDiameter = (int)fan.SweepDiameter,
                    FanWeight = (int)fan.FanWeight,
                    MountingLocation = fan.MountingLocation

                });
            }
            return _lstFanUI;
        }//getfan

        public List<VacuumSpecDetailUI> GetAllVacuums()
        {
            _entities = new JooleDataBaseEntities();
            var _lstVacuumUI = new List<VacuumSpecDetailUI>();
            var _lstVacuums = _entities.tblTechSpecsVacuums.ToList();

            foreach (var vacuum in _lstVacuums)
            {
                _lstVacuumUI.Add(new VacuumSpecDetailUI
                {
                    ProductID = vacuum.ProductID,
                    AirFlowCFM = (int)vacuum.AirFlowCFM,
                    PowerWattsMax = (int)vacuum.PowerWattsMax,
                    PowerWattsMin = (int)vacuum.PowerWattsMin,
                    OperatingVoltageMax = (int)vacuum.OperatingVoltageMax,
                    OperatingVoltageMin = (int)vacuum.OperatingVoltageMin,
                    FanSpeedMax = (int)vacuum.FanSpeedMax,
                    FanSpeedMin = (int)vacuum.FanSpeedMin,
                    MaxSound = (int)vacuum.MaxSound,
                    CleaningWidth = (int)vacuum.CleaningWidth,
                    AttachmentReach = (int)vacuum.AttachmentReach,
                    VacuumWeight = (int)vacuum.VacuumWeight,
                    FormFactor = vacuum.FormFactor

                });
            }
            return _lstVacuumUI;
        }//getvacuum

        public List<ToasterSpecDetailUI> GetAllToasters()
        {
            _entities = new JooleDataBaseEntities();
            var _lstToasterUI = new List<ToasterSpecDetailUI>();
            var _lstToasters = _entities.tblTechSpecsToasters.ToList();

            foreach (var toaster in _lstToasters)
            {
                _lstToasterUI.Add(new ToasterSpecDetailUI
                {
                    ProductID = toaster.ProductID,
                    NumOfPrograms = (int)toaster.NumOfPrograms,
                    PowerWattsMax = (int)toaster.PowerWattsMax,
                    PowerWattsMin = (int)toaster.PowerWattsMin,
                    OperatingVoltageMax = (int)toaster.OperatingVoltageMax,
                    OperatingVoltageMin = (int)toaster.OperatingVoltageMin,
                    HeatMax = (int)toaster.HeatMax,
                    HeatMin = (int)toaster.HeatMin,
                    OutputPerHour = (int)toaster.OutputPerHour,
                    SlotWidth = (int)toaster.SlotWidth,
                    ToasterHeight = (int)toaster.ToasterHeight,
                    ToasterWeight = (int)toaster.ToasterWeight,
                    Slot = toaster.Slot

                });
            }
            return _lstToasterUI;
        }//gettoaster
    }
}
