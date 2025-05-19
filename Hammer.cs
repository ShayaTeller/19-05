using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_05_25
{
    internal class Hammer:Tool
    {
        int Impact_strength;

         public Hammer(int impact_strength, string name, int weight,string category) :base( name,  weight,category)
        {
            Impact_strength = impact_strength;
        }
        public override void Describe()
        {
            Console.WriteLine($"hello my NAME is {Name}, in my weight is {Weight}, my strength is: {Impact_strength} ");
        }
        public override void Use()
        {
            Console.WriteLine("Drives nails or breaks objects");
        }
    }
}
