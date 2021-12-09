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
            feladatokLb.ItemsSource = feladatok;
            UjCheckBox();

        }
        private  void UjCheckBox()
        {
            CheckBox uj = new CheckBox();
            uj.IsChecked = false;
            uj.Content = szovegTb.Text;
            feladatok.Add(uj);
            uj.Checked += new RoutedEventHandler(Szinezes);
            uj.Unchecked += new RoutedEventHandler(Szinezes);
            feladatokLb.Items.Refresh();
        }

        public void Szinezes(object sender, RoutedEventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            if (box.IsChecked == true)
            {
                box.FontStyle = FontStyles.Italic;
                box.Foreground = Brushes.Gray;
            }
            else
            {
                box.FontStyle = FontStyles.Normal;
                box.Foreground = Brushes.Black;
            }
        }

       
    }
}
