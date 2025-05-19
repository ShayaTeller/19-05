
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_05_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PipeCutter pipe = new PipeCutter("8.9", "peper", 25,"");
            Hammer hammer1 = new Hammer(25, "hammerry", 54);
            Wrench newwrench = new Wrench(12, "wrenchy", 18,"");
            Saw newsaw = new Saw("21", "sawle", 23,"");
            Screwdriver newscr = new Screwdriver("pass", "driller", 17);
            Drill drill1 = new Drill(7, "mefager", 68,"");
            NailGun nailGun1 = new NailGun("nanle", 87,"");
            WireStripper wireStripper1 = new WireStripper("stripper", 74,"");


            Toolbox a = new Toolbox(pipe);
            a.myTool = wireStripper1;
            a.myTool = newsaw;
            a.PrintTools();



            }
        }
    }
