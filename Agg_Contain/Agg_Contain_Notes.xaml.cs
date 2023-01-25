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
