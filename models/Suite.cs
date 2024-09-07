using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_net_hotelaria.models
{
    public class Suite(string suiteType, int capacity, decimal dailyCharges)
    {
        public int Capacity { get; set; } = capacity;
        public string SuiteType { get; set; } = suiteType;
        public decimal DailyCharges { get; set; } = dailyCharges;
    }
}