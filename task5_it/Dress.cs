namespace task5_it
{
    internal class Dress : ClothesAbs
    {
        public int Length { get; set; }
        public bool HasSleeves { get; set; }
        public Dress(string fName, int fDurability) : base(fName, fDurability)
        {
        }

        public override void addLabel(string label)
        {
            labels.Add(label.ToUpper());
        }

        public override void PatchUp(int money)
        {
            CurrDurability += (int)(((double)money) / 20 * ((double)Durability / 100));
        }

        public override void WearOut(int times)
        {
            for (int i = 0; i < times; i++)
            {
                CurrDurability -= 10;
            }
        }

        public void CutOff(int forLength)
        {
            Length -= forLength;
            if (Length < 0)
            {
                throw new Exception("Dress is too short");
            }
        }
    }
}
