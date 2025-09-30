using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gatya.Model
{
    public class gatyaEventArgs: EventArgs
    {
        public gatyaEventArgs(string meret)
        { 
            this.meret = meret;
        }
        public string meret { get; private set; }
    }
}
