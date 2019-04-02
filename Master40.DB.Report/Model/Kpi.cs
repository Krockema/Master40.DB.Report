using Master40.DB.Report.Model.Base;

namespace Master40.DB.Report.Model
{
    public class Kpi : BaseEntity
    {
        public double Value { get; set; }
        public double ValueMin { get; set; }
        public double ValueMax { get; set; }
        public double Count { get; set; }
        public string Name { get; set; }
        public bool IsKpi { get; set; }
        public bool IsFinal { get; set; }
        public int KpiType { get; set; }
        public int SimulationConfigurationId { get; set; }
        public int SimulationType { get; set; }
        public int SimulationNumber { get; set; }
        public int Time { get; set; }
    }
}
