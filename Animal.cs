using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_W23_Lecture_7
{
    internal class Animal
    {
        // What are our 3 keywords for controling method inheritance
        // virtual, override, new
        public string _name;

        // What word do i use to give permissio to change a method in a child?
        // Virtual lets a child OVERRIDE a method
        // Virtual 
        public virtual string Sound()
        {       
            return "Animal Call";
        }
    }
}
