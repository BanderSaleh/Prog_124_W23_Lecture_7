using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_W23_Lecture_7.Agg_Contain
{
    internal class Teacher
    {
        string _firstName;
        string _lastName;
        int _yearsWorked;
        
        public Teacher(string firstName, string lastName, int yearsWorked)
        {
            FirstName = firstName;
            LastName = lastName;
            YearsWorked = yearsWorked;
        }

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


        public override string ToString()
        {
            return $"{_firstName} {_lastName} - Years Worked: { _yearsWorked}";
        }
    }
}
