using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    class Dogs
    {
        public string Make { get; set;}
        public string Typeofdogs { get; set; }
        public string Choosedog { get; set; }

        public string Storename { get; set; }

        

        public Dogs()
        {
            this.Make = "German Sheperd";
        }    

        public Double DetermineMarketValue()
        {
            return 500.00;
        }

    }
}
