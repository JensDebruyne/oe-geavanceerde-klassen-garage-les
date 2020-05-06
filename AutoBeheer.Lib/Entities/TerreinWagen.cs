using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBeheer.Lib.Entities
{
    public class TerreinWagen
    {
        private int percentageOffRoad;

        public int PercentageOffRoad
        {
            get { return percentageOffRoad; }
            set
            {
                percentageOffRoad = value;
            }
        }


        public TerreinWagen(string naam, float tankInhoud, float verbruik, int percentageOffRoad, Guid? id = null) 
        {
            PercentageOffRoad = percentageOffRoad;
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
