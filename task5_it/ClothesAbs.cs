using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5_it
{
    internal abstract class ClothesAbs : IFiber
    {
        protected string name;
        protected int Durability { get; set; }
        protected int CurrDurability { get; set; }
        public string Name { get => name; set => name = value; }
        protected List<String> labels = new();

        protected ClothesAbs(string fName, int fDurability)
        {
            name = fName;
            Durability = fDurability;
            CurrDurability = IFiber.MAX_DURABILITY;
        }

        public abstract void PatchUp(int money);

        public abstract void WearOut(int times);
        public abstract void addLabel(string label);
    }
}
