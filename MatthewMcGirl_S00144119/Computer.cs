using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MatthewMcGirl_S00144119
{
    public class Computer
    {
        public Computer(string v1, decimal v2, string v3, string v4, string v5, string v6, string v7, string v8)
        {
            this.compName = v1;
            this.compPrice = v2;
            this.compOS = v3;
            this.compHarddrive = v4;
            this.compMemory = v5;
            this.compProcessor = v6;
            this.manfImage = v7;
            this.compImage = v8;
        }

        public string compID { get; set; }
        public string compName { get; set; }
        public decimal compPrice { get; set; }
        public string compOS { get; set; }
        public string compHarddrive { get; set; }
        public string compMemory { get; set; }
        public string compProcessor { get; set; }
        public string manfImage { get; set; }
        public string compImage { get; set; }



        public virtual List<Computer> Computers { get; set; }

        public void DecreasePrice(decimal amount)
        {
            decimal discount20 = (80 / 100);
            decimal finaldecreasedPrice = compPrice * discount20;
        }




        
    }

    public class CompData : DbContext
    {
        public CompData() : base("MyCompData") { }
        public DbSet<Computer> Computers { get; set; }
    }
}
