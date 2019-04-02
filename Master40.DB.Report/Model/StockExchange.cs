using Master40.DB.Report.Model.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Master40.DB.Report.Model
{
    public class StockExchange : BaseEntity
    {
        public int StockId { get; set; }
        public Guid TrakingGuid { get; set; }
        public int SimulationConfigurationId { get; set; }
        public int SimulationType { get; set; }
        public int SimulationNumber { get; set; }
        public string StockName { get; set; }
        public int RequiredOnTime { get; set; }
        public int State { get; set; }
        public decimal Quantity { get; set; }
        public int Time { get; set; }
        public int ExchangeType { get; set; }

    }
}
