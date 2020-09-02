using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatthewMcGirl_S00144119;

namespace Data_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            CompData db = new CompData();

            using(db)
            {
                Computer c1 = new Computer("Acer 714", 599.99m, "ChromeOS", "128GB eMMC", "8GB", "Intel Core i3", "/images/acer_logo.png", "/images/acer.png");

                Computer c2 = new Computer("Hp Pavilion 14", 539m, "Windows 10", "256GB SSD", "8GB", "Intel Core i3", "/images/hp_logo.png", "/images/hp_pavilion.png");

                db.Computers.Add(c1);
                db.Computers.Add(c2);

                Console.WriteLine("Added computers to database");

                db.SaveChanges();

                Console.WriteLine("Saved!");
            }
        }
    }
}
