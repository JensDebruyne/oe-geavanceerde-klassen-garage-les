using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBeheer.Lib.Entities
{
    public class Auto
    {
        public Guid Id { get; private set; }

        public string Naam { get; set; }

        private float tankInhoud;

        public float TankInhoud
        {
            get { return tankInhoud; }
            set
            {
                tankInhoud = value;
            }
        }

        private float verbruik;

        public float Verbruik
        {
            get { return verbruik; }
            set
            {
                verbruik = value;
            }
        }

        public float RijBereik { get; set; }

        public Auto(string naam, float tankInhoud, float verbruik, Guid? id = null)
        {
            Naam = naam;
            TankInhoud = tankInhoud;
            Verbruik = verbruik;
            Id = (id == null) ? Guid.NewGuid() : (Guid)id;
        }

        public override string ToString()
        {
            return $"{Naam} ({RijBereik} km)";
        }

        public void BerekenRijBereik()
        {
            RijBereik = TankInhoud / Verbruik * 100;
        }
    }
}
