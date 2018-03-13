using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinChitare
{
    public class GuitarSpec
    {
        public Builder Builder { get; }
        public string Model { get; }
        public Type Type { get; }
        public Wood BackWood { get; }
        public Wood TopWood { get; }

        public GuitarSpec(Builder builder, string model, Type type, Wood backWood, Wood topWood)
        {
            this.Builder = builder;
            this.Model = model;
            this.Type = type;
            this.BackWood = backWood;
            this.TopWood = topWood;
        }

        public Boolean Matches(GuitarSpec aGuitarSpec)
        {
            if (Builder == aGuitarSpec.Builder
                && (
                    (aGuitarSpec.Model == "") ||
                    (Model.ToLower() == aGuitarSpec.Model.ToLower())
                    )
                && Type == aGuitarSpec.Type
                && BackWood == aGuitarSpec.BackWood
                && TopWood == aGuitarSpec.TopWood
                )
            {
                return true;
            }
            return false;
        }
    }
}
