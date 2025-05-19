using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_05_25
{
    internal class NailGun : Tool
    {
     public NailGun(string name,int weight, string category) : base(name, weight, category) { }

    public override void Describe()
        {
            Console.WriteLine($"hello my NAME is: {Name}, in my weight is: {Weight} ");

        }
        public override void Use()
        {
            Console.WriteLine("Drives nails quickly using compressed force");

        }
    }
    
}
