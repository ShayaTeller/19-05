using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_05_25
{
    internal class Screwdriver : Tool
    {
        public string Type;


        public Screwdriver(string Type, string name, int weight,string category) : base( name,  weight,category)
        {
            this.Type = Type;
        }
        public override void Describe()
        {
            Console.WriteLine($"hello my NAME is {Name}, in my weight is {Weight}, and my type is: {Type} ");
        }
        public override void Use()
        {
            Console.WriteLine($"im Tightens or loosens screws using torque.");
        }
    }
}