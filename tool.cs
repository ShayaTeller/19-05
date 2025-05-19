using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_05_25
{
    internal class Tool
    {
        protected string Name { get; set; }
        protected int Weight { get; set; }
        
        protected string Category { get; set; }
        public Tool(string name,int weight, string category) {
            Name = name;
            Weight = weight;
        }

            public virtual void Describe()
        {
            Console.WriteLine($"{Name} + {Weight}");

        }
        public virtual void Use()
        {
            Console.WriteLine("Tool is being used");
        }
    }

}
