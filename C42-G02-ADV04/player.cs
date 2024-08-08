using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_ADV04
{
    internal class player
    {
        public string playername {  get; set; }
        public string teamname {  get; set; }
        public void Run() { 
        Console.WriteLine($"player:{playername}IS Runing.....");
        }
    }
}
