using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoBeheer.Lib.Entities;

namespace AutoBeheer.Lib.Services
{
    public class AutoManagement
    {
        public List<Auto> Autos { get; set; } = new List<Auto>();

        public AutoManagement(bool metMockData = false)
        {
            if (metMockData) MaakMockData();
        }

        void MaakMockData()
        {
            Autos = new List<Auto>
            {
                new Auto("VolksKar", 50.6F, 7.6F ),
                new Auto("Eau Pil", 60F, 5.7F ),
                //new TerreinWagen("Sea Shy", 80, 12, 50),
                //new Hybrid("Jetota Anterior", 55, 6, 300)
            };
        }
    }
}
