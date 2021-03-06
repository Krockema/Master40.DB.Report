﻿using Master40.DB.Report.Model.Base;

namespace Master40.DB.Models
{
    public class SimulationOperation : BaseEntity
    {
        public int SimulationConfigurationId { get; set; }
        public int SimulationType { get; set; }
        public int SimulationNumber { get; set; }
        public int Time { get; set; }
        public string WorkScheduleName { get; set; }
        public string Article { get; set; }
        public int Start { get; set; }
        public int End { get; set; }
        public int EstimatedStart { get; set; }
        public int EstimatedEnd { get; set; }
        public string Machine { get; set; }
        public string WorkScheduleId { get; set; }
        public string ProductionOrderId { get; set; }
        public int DueTime { get; set; }
        public string OrderId { get; set; }
        public string CreatedForOrderId { get; set; }
        public int HierarchyNumber { get; set; }
        public string Parent { get; set; }
        public string ParentId { get; set; }

    }
}