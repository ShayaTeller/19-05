using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_05_25
{
    internal class Saw:Tool
    {
        string Teeth;

         public Saw(string teeth, string name, int weight, string category) : base( name,  weight, category)
        {
            Teeth = teeth;
        }

        public override void Describe()
        {
            Console.WriteLine($"hello my NAME is {Name}, in my weight is {Weight}, and  i have  : {Teeth} ");
        }
        public override void Use()
        {
            Console.WriteLine("Cuts materials like wood or metal.");
        }
    }
}
