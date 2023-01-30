using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_W23_Lecture_7
{
    internal class Hippo : Animal
    {
        //The : symbol means inherit
        //Child : Parent
        //Hippo : Animal
        //Derived : base

        // Access Modifers are all about giving *what* to other programmers?
        // Answer: Permission

       
        // C# will check for the nearest "declaration" of a method
        // Keyword "new" Prevents others from overriding in derived classes
        public new virtual string Sound()
        {
            //sets a value and runs the return action
            return "Snorting Roar";
        }

    }
}
