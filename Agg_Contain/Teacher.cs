using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_W23_Lecture_7.Agg_Contain
{
    internal class Teacher
    {
        // defined 3 strings to assign values to my Teacher object later
        string _firstName;
        string _lastName;
        int _yearsWorked;



        // I then highlighted the 3 strings to convert to constructor:
        // right-clicked, then clicked Quick Actions & Refactorings,
        // then clicked generated constructor.
        // My data has now transformed into a constructor:
        public Teacher(string firstName, string lastName, int yearsWorked)
        {
            FirstName = firstName;
            LastName = lastName;
            YearsWorked = yearsWorked; // Aggregation
        }

        // Use get and Set to assign values to our 2 new strings and 1 new integer
        public string FirstName { 
            get => _firstName; 
            set
            {
                if(value != "") {
                    _firstName = value;
                }
                else
                {
                    _firstName = "invalid name";
                }
            }
                
        }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int YearsWorked { get => _yearsWorked; set => _yearsWorked = value; }


        // A Constructor that returns the current Teacher details (2 strings and 1 integer) 
        public override string ToString()
        {
            return $"{_firstName} {_lastName} - Years Worked: { _yearsWorked}";
        }
    }
}
