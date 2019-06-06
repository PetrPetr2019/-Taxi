using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDataStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Truck> trucks = new List<Truck>
            {
                new Truck{ModelAvto = "Камаз", Carrying = 20, DataofIssue = 1999, DataofMajorOverhaur = 2015, NumberGos = 374532, EncryptPark = 23, ID = 1},
                new Truck{ModelAvto = "Белаз", Carrying = 200, DataofIssue = 2000, DataofMajorOverhaur = 2018, NumberGos = 34853, EncryptPark =12, ID = 2}
            };
        }
    }
}
