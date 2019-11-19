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

namespace InclassDatabase9._17._19
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        //creating instance
        DB_128040_practiceEntities db = new DB_128040_practiceEntities();

        public MainWindow()
        {
            InitializeComponent();

            txtStudentID.Text = string.Empty;
        }

        private void btnFetch_Click(object sender, RoutedEventArgs e)
        {

            int studentID;

           if( Int32.TryParse(txtStudentID.Text, out studentID)==true)
            {
                foreach (var student in db.Students)
                {
                    if(student.StudentID==studentID)
                    {
                        string temp = ($"{student.LastName}, {student.FirstName}");
                        listData.Items.Add(student);
                    }
                   
                }

            }
            else
            {
                foreach (var student in db.Students)
                {
                    string temp = ($"{student.LastName}, {student.FirstName}");
                    listData.Items.Add(student);
                }
            }


        }
    }
}
