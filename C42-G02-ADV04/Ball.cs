using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_ADV04
{
    internal class Ball
    {
        public int ID { get; set; }
        private location location;

        public location Location {
            get { return location;}
            set {location = value;}
        }

        public override string ToString()
        {
            return $"id:{ID},location:{location}";
        }
    }
}
