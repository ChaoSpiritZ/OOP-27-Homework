using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_27_Homework
{
    public class Car
    {
        public string Brand { get; private set; }
        public bool TotalLost { get; private set; }
        public bool NeedsRepair { get; set; }

        public Car(string brand, bool totalLost, bool needsRepair)
        {
            if(totalLost && !needsRepair)
            {
                throw new RepairMismatchException($"failed constructing car: a car cannot be beyond repair but not needing a fix");
            }
            Brand = brand;
            TotalLost = totalLost;
            NeedsRepair = needsRepair;
        }
    }
}
