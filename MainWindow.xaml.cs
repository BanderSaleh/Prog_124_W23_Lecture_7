using Prog_124_W23_Lecture_7.Agg_Contain;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog_124_W23_Lecture_7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            new Agg_Contain_Notes().Show();
            // What is aggregation
            // It is a Has-A relationship

            //create new instances
            Animal animal = new Animal();
            Hippo hungry = new Hippo();
            BabyHippo babyhippo = new BabyHippo();

            //MessageBox.Show("Hello World! TEST Messege!");
            //Return a popup message to the user with the child overriden string returned
            MessageBox.Show(babyhippo.Sound());


        }
    }
}
