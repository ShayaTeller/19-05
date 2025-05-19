using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_05_25
{
    internal class Toolbox
    {
        public List<Tool> myTools = new List<Tool>();
        public Tool myTool;

        public Toolbox(Tool tool)
        {
            myTools.Add(tool);
        }



        public void PrintTools()
        {
            foreach (var tool in myTools)
            {
                tool.Describe();

            }
        }



    } 
}
