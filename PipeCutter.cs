using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_05_25
{
    internal class PipeCutter : Tool
    {

        string MaximumThickness;
        
        public PipeCutter(string maximumThickness,string name,int weight, string category) : base(name,weight, category)
        {
            MaximumThickness = maximumThickness;
        }
        public override void Describe()
        {
            Console.WriteLine($"hello my NAME is {Name}, in my weight is {Weight}, and my maximum thickness is: {MaximumThickness} ");
        }
        public override void Use()
        {
            Console.WriteLine("Cuts pipes cleanly and accurately");
        }
    }
}




