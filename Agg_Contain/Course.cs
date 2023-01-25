using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_W23_Lecture_7.Agg_Contain
{
    internal class Course
    {
        string _courseName;
        string _location;
        Teacher _teacher;

        // if an access modifier is not explicit, what is the default access modifier?
        // Default access is private

        // what are my 4 main access modifiers?
        // private, public , internal, protected
        // 

        // Contains means an object is neseccary to work
        List<Student> _classRoster = new List<Student>();


        // I"m not allowing users to pass in their own list of students

        // Aggragate
        // Has-A indicate that an object is used IN a class
        // But can exist outside the class

        // null indicates it does not exist in memory
        public Course(string courseName, string location)
        {
            _courseName = courseName;
            _location = location;
        }

        public Course(string courseName, string location, Teacher teacher)
        {
            _courseName = courseName;
            _location = location;
            _teacher = teacher;
        }

   

        public string CourseName { get => _courseName; set => _courseName = value; }
        public string Location { get => _location; set => _location = value; }
        internal Teacher Teacher {
            get {
                if(_teacher == null)
                {
                    return new Teacher("", "" , 0);
                }

                return _teacher;
            }
            set => _teacher = value; 
        }


        // Restricting users from settting the Class Roster of students.

        // The protected Access Modifieri allows the Class and it's Derived Children to access members
        public List<Student> ClassRoster { 
            get => _classRoster;
            protected set => _classRoster = value;
        }

        // I am creating a method to ADD students to the list. But users are unable to DIRECTLY access that list.
        public void AddStudent(Student student)
        {
            _classRoster.Add(student);
        }
    }
}
