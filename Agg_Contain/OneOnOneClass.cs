using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_W23_Lecture_7.Agg_Contain
{
    internal class OneOnOneClass : Course
    {
        Student _student;

        public OneOnOneClass(string courseName, string location, Student student) : base(courseName, location)
        {
            _student = student;
            ClassRoster = null;
        }

        public OneOnOneClass(string courseName, string location, Teacher teacher, Student student) : base(courseName, location, teacher)
        {
            _student = student;

            ClassRoster = null;

        }


    }
}
