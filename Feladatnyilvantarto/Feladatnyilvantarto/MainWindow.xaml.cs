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

namespace Feladatnyilvantarto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        List<CheckBox> feladatok = new List<CheckBox>();


        private void hozzaadGomb_Click(object sender, RoutedEventArgs e)
        {
            CheckBox uj = new CheckBox();

            uj.Content = szovegTb.Text;

            feladatok.Add(uj);

            feladatokLb.ItemsSource = feladatok;

            feladatokLb.Items.Refresh();

        }
    }
}
