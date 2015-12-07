using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_10
{
    class cool
    {
        public int Number { get; set; }

        // override innebär att man skriver en ny förbättrad version som vi ärvt från en basklass
        // override tar befälat över metoden
        // basklassens virtual säger att är ok att göra en override
        // override kan göras på metoder, properties, events, indexer
        //här görs override från objekt f12 och titta

        object obj;

        public override string ToString()
        {
            return base.ToString();
            {
                return Number.ToString();
            }
        }
    }
}
