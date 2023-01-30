using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Prog_124_W23_Lecture_7.Agg_Contain
{
    /// <summary>
    /// Interaction logic for Agg_Contain_Notes.xaml
    /// </summary>
    public partial class Agg_Contain_Notes : Window
    {
        List<Teacher> teachers = new List<Teacher>();

        public Agg_Contain_Notes()
        {
            InitializeComponent();

            // Containment
            // Contaiment is when an object CONTAINS another object, but cannot exhist independently of the other

            //List<Student> csi140Roster = new List<Student>();

            //created a quick value for our list to test
            Course csi140 = new Course(
                "Csi 140", 
                "Downtown Renton", 
                new Teacher("Will", "Cram", 2 ));
        }

        public void AggregateExample()
        {
            // Aggrgate TAKES another object, but does not require

            Teacher will = new Teacher("", "Cram", 2);
            Course csi124 = new Course("Csi 124", "Downtown Renton");

            teachers.Add(will);
            teachers.Add(new Teacher("Anne", "Nguyen", 1));
            teachers.Add(new Teacher("Josh", "Emery", 3));

            csi124.Teacher = teachers[1];

            MessageBox.Show(csi124.Teacher.ToString());
        }
    }
}




/*
QUESTIONS:
 * Access Modifiers

-if an access modifier is not explicit, what is the default access modifier?
>Default access is private

-what are my 4 main access modifiers?
>private, public, internal, protected

-Access Modifers are all about giving what to other programmers?
 >who does or who doesn't have access to certain features.

 * Inheritance

-What are our 3 keywords for controlling method inheritance?
(Hint: Start with V, O, and N)
>virtual, override, new
 

-What symbol do we use to inherit?
>The : symbol means inherit (Child : Parent)

-With our BabyHippo : Hippo and Hippo : Animal relationships, which are base classes, which are derived classes?
>Derived : base
Hippo (child/Derived class) : Animal (parent/Base class)
BabyHippo (child/Derived class): Hippo (parent/Base class)

 * New Keyword

-What does the new keyword do to an overridden method?
>Keyword "new" Prevents others from overriding in derived classes, while
Override lets me change the Virtual Method from the base class (In this case it's Animal Class)

 * Aggregate

-Aggregation is a ***-A relationship. What is ***-A?
>An Aggregation is a Has-A relationship,
meaning several separate pieces that form a whole. 
With a Has-A relationship, one object HAS-Another object.
But that object comes from outside of the original object.

-An aggregate relationship means that two objects can what?
>Two objects can exist independent of one another,
but then can be passed to form one whole object,


-Which classes are an example of an aggregate relationship?
>The Course Class, Student Class, and Teacher Class.

-What fields in our classes represent Aggregation?
>public Course, public Student, and public Teacher.

 * Containment

-Containment means that one object can't ______ without another.
>Containment means that one object can't exist without another.

-Which classes are an example of Containment?
>OneOnOneClass Class and Course Class

What field in our classes in the example represent Containment?
>public OneOnOneClass and public List<Student> ClassRoster
 */