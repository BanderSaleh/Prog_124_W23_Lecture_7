using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_W23_Lecture_7
{
    //Child class using the : symbol to inherit from the parent class "Hippo"
    internal class BabyHippo : Hippo
    {
        // "Override" lets me change the Virtual Method from the base
        public override string Sound()
        {
            return "Baby Snorting Roar";
        }
    }
}
