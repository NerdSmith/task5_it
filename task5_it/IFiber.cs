using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5_it
{
    internal interface IFiber
    {
        protected const int MAX_DURABILITY = 100;

        public string Name { get; set; }

        public void PatchUp(int money);
        public void WearOut(int times);
    }
}
