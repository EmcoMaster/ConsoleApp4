using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Cat
    {
        public string Make { get; set;}
        public string Typeofcats { get; set; }
        public string Choosecat { get; set; }

        public string Storename { get; set; }

       

        public Cat()
        {
            this.Make = "Persian cat";
            
        }
        public double DetermineMarketValue()
        {
            return 400.00;
        }
    }
}
