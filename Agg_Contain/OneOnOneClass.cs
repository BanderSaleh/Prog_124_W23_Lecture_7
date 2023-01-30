using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_W23_Lecture_7.Agg_Contain
{
    // This class is the child class and inherits the parent class "Course"
    internal class OneOnOneClass : Course
    {
        //declared the student object
        Student _student;
        //Constructor to get and set values for the current student and assigned teacher
        public OneOnOneClass(string courseName, string location, Student student) : base(courseName, location)
        {
            _student = student; // Containment
            // null indicates it does not exist in memory
            ClassRoster = null; // Default value until it gets overriden when called later
        }
       
        public OneOnOneClass(string courseName, string location, Teacher teacher, Student student) : base(courseName, location, teacher)
        {
            _student = student;

            ClassRoster = null;

        }


    }
}
