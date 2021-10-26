using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Fish
    {
        public string Make { get; set;}
        public string Typeoffishes  { get; set; }
        public string Choosefish { get; set; }

        public string Storename { get; set; }

       

        public Fish()
        {
            this.Make = "Atlantic Salmon";
        }
        public double DetermineMarketValue()
        {
            return 150.00;
        }
    }
}
