using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewMcGirl_S00144119
{
    public class Computer
    {
        public int compID { get; set; }
        public string compName { get; set; }
        public decimal compPrice { get; set; }
        public string compOS { get; set; }
        public string manfImage { get; set; }
        public string compImage { get; set; }
        public string compHarddrive { get; set; }
        public string compMemory { get; set; }
        public string compProcessor {get; set;}
        public decimal finaldecreasedPrice { get; set; }

        public void DecreasePrice(decimal amount)
        {
            decimal discount20 = (80 / 100);
            decimal finaldecreasedPrice = compPrice * discount20;
        }
    }
}
