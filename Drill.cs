using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _19_05_25
{
    internal class Drill:Tool
    {
        int Depth;

        public Drill(int depth, string name, int weight, string category) :base( name,  weight, category)
        {
            Depth = depth;
        }

        public override void Describe()
        {
            Console.WriteLine($"hello my NAME is {Name}, in my weight is {Weight}, my depth is : {Depth} ");
        }
        public override void Use()
        {
            Console.WriteLine("Creates holes in various materials");
        }
    }
}
