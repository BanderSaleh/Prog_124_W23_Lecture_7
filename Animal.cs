using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_W23_Lecture_7
{
    internal class Animal
    {
        //This project will use these functions: virtual, override, new

        //Fun Fact: All of Microsoft Office was built in Visual Basic (or SQL Server I think)
        public string _name;


        // 3 keywords for controlling method inheritance: virtual, override, new

        // What word do i use to give permissio to change a method in a child?
        // Virtual lets a child OVERRIDE a method
        // Virtual 
        // Constructor:
        public virtual string Sound()
        {
            //sets a value and runs the return action
            return "Animal Call";
        }
    }
}
