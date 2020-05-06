using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBeheer.Lib.Entities
{
    public class Hybrid
    {
        private int capaciteitBatterij;

        public int CapaciteitBatterij
        {
            get { return capaciteitBatterij; }
            set
            {
                capaciteitBatterij = value;
            }
        }

        public Hybrid(string naam, float tankInhoud, float verbruik, int capaciteitBatterij, Guid? id = null) 
            
        {
            CapaciteitBatterij = capaciteitBatterij;
        }

        public void BerekenRijBereik()
        {
            
        }

        public override string ToString()
        {
            return "";
        }
    }
}
