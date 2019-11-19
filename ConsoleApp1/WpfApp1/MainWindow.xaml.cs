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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<char, List<string>> Fruits = new Dictionary<char, List<string>>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            string fruit = txtFruit.Text;
            char letter = fruit.ToUpper()[0];


            if(Fruits.ContainsKey(fruit[0]))
            {
                Fruits[fruit[0]].Add(fruit);
            }
            else
            {
                List<string> temp = new List<string>();
                temp.Add(fruit);
                Fruits.Add(fruit[0], temp);
            }


           





        }
    }
}
