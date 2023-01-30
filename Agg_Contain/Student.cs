using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_W23_Lecture_7.Agg_Contain
{
    internal class Student
    {
        // Declaring 2 strings we want to use to store values for the current Student Selected
        string _firstName;
        string _lastName;

        // Constructors used to Get and Set
        public Student(string firstName, string lastName)
        {
            // get (on left) and set (on right)
            _firstName = firstName;
            _lastName = lastName; // Aggregation
        }
        
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
    }
}
