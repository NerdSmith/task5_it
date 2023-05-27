
using System.Diagnostics;

namespace task5_it
{
    internal class Short : ClothesAbs
    {
        public string Color { get; set; }
        public bool HasPockets { get; set; }
        public Short(string fName, int fDurability) : base(fName, fDurability)
        {
        }

        public override void addLabel(string label)
        {
            labels.Add(label.ToUpper());
        }

        public override void PatchUp(int money)
        {
            CurrDurability += (int)(((double)money) * ((double)money) / 10 * ((double)Durability / 50));
        }

        public override void WearOut(int times)
        {
            for (int i = 0; i < times; i++)
            {
                CurrDurability -= 5;
            }
        }

        public void ChangeColor(string newColor)
        {
            Color = $"{Color}({newColor})";
        }

        public override string? ToString()
        {
            return $"{Name}:: durability: {Durability} ({CurrDurability}), color: {(Color != null ? Color : "None")}, hasPockets: {(HasPockets ? "Yes" : "No")}";
        }
    }
}
