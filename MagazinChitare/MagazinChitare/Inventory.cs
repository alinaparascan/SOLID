using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinChitare
{
    public class Inventory
    {
        public List<Guitar> Chitare { get; set; }

        public Inventory()
        {
            Chitare = new List<Guitar>();
            PopulateList();
        }      

        public void PopulateList()
        {
            Guitar chitara;
            chitara = new Guitar("CHI0001", 1999.99, new GuitarSpec(Builder.MelodiaSA, "Model1", Type.PeAburi, Wood.Brad, Wood.Stejar));
            Chitare.Add(chitara);
            chitara = new Guitar("CHI0002", 589.23, new GuitarSpec(Builder.Romchitara, "Model1", Type.Acustica, Wood.Molid, Wood.Brad));
            Chitare.Add(chitara);
            chitara = new Guitar("CHI0003", 1.59, new GuitarSpec(Builder.Chitaro, "Model Chitaro 1", Type.Electrica, Wood.Stejar, Wood.Stejar));
            Chitare.Add(chitara);
            chitara = new Guitar("CHI0004", 0.49, new GuitarSpec(Builder.Romchitara, "Model2", Type.PeAburi, Wood.Molid, Wood.Stejar));
            Chitare.Add(chitara);
            chitara = new Guitar("CHI0005", 2850.25, new GuitarSpec(Builder.Chitaro, "Chitara de lux", Type.PeAburi, Wood.Brad, Wood.Brad));
            Chitare.Add(chitara);
            chitara = new Guitar("CHI0006", 5900, new GuitarSpec(Builder.Chitaro, "Model Chitaro 2", Type.Electrica, Wood.Stejar, Wood.Stejar));
            Chitare.Add(chitara);
            chitara = new Guitar("CHI0007", 5900, new GuitarSpec(Builder.Romchitara, "Model 3", Type.Electrica, Wood.Stejar, Wood.Stejar));
            Chitare.Add(chitara);
        }
        public Guitar GetGuitar(string aSerialNumber)
        {
            for (int i=0; i < Chitare.Count; i++)
            {
                if (Chitare[i].SerialNumber.ToLower() == aSerialNumber.ToLower())
                {
                   return Chitare[i];
                }
            }
            return null;
        }
        public List<Guitar> Search(GuitarSpec aGuitarSpec)
        {
            List<Guitar> aReturn = new List<Guitar>();
            for (int i = 0; i < Chitare.Count; i++)
            {
                if (Chitare[i].Spec.Matches(aGuitarSpec))
                {
                    aReturn.Add(Chitare[i]);
                }
            }
            return aReturn;
        }
    }
}
