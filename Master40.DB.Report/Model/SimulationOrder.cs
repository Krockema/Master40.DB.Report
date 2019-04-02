using Master40.DB.Report.Model.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Master40.DB.Report.Model
{
    public class SimulationOrder : BaseEntity
    {
        public string Name { get; set; }
        public int OriginId { get; set; }
        public int DueTime { get; set; }
        public int CreationTime { get; set; }
        public int FinishingTime { get; set; }
        public int BusinessPartnerId { get; set; }
        public int State { get; set; }
        public int SimulationConfigurationId { get; set; }
        public int SimulationType { get; set; }
        public int SimulationNumber { get; set; }
    }
}
