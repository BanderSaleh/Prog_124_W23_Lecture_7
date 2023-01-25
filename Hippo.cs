using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_W23_Lecture_7
{
    internal class Hippo : Animal
    {
        // What symbol do we use to inherit - Colon :
        // Which class is the parent, which is the child
        // Child : Parent
        // Hippo : Animal
        // Derived : base

        // Access Modifers are all about giving *what* to other programmers?
        // Permission

        // Override lets me change the Virtual Method, Sound from the base
        //public over string Sound()
        //{
        //    return "Snorting Roar";
        //}

        // C# will check for the nearest "declaration" of a method

        // Keyword new
        // Prevents others from overriding in derived classes
        public new virtual string Sound()
        {
            return "Snorting Roar";
        }

    }
}
