using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_05_25
{
    internal class Wrench : Tool
    {
        public int QuantityKeys;

         public Wrench(int quantityKeys, string name, int weight, string category) : base(name, weight, category)
        {
            QuantityKeys = quantityKeys;
        }
        
        public override void Describe()
        {
            Console.WriteLine($"hello my NAME is {Name}, in my weight is {Weight}, and my quantity keys is: {QuantityKeys} ");
        }
        public override void Use()
        {
            Console.WriteLine("Grips and turns nuts or bolts");
        }
    }
}