using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5_it
{
    internal class Costume : ClothesAbs
    {
        public string? Style { get; set; }
        public string? Price { get; set; }

        public Costume(string fName, int fDurability) : base(fName, fDurability)
        {
        }

        public override void addLabel(string label)
        {
            labels.Add(label.ToUpper());
        }

        public override void PatchUp(int money)
        {
            CurrDurability += (int)(((double)money) / 10 * ((double)Durability / 100));
        }


        public override void WearOut(int times)
        {
            for (int i = 0; i < times; i++)
            {
                CurrDurability -= (int)(10 * (1 - ((double)Durability / 100)));
            }
        }

        public void admire()
        {
            CurrDurability -= (int)(1 - ((double)Durability / 1000));
        }

        public override string? ToString()
        {
            return $"{Name}:: durability: {Durability} ({CurrDurability}), style: {(Style != null ? Style : "None")}, price: {(Price != null ? Price : "None")}";
        }
    }
}
