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
        List<object> feladatok = new List<object>();
        List<object> toroltElemek = new List<object>();

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

        public void torolGomb_Click(object sender, RoutedEventArgs e)
        {
            
            int torlesIndex = feladatokLb.SelectedIndex;
            toroltElemek.Add(feladatokLb.SelectedItem);
            feladatok.RemoveAt(torlesIndex);
            toroltLb.ItemsSource = toroltElemek;
            toroltLb.Items.Refresh();
            feladatokLb.Items.Refresh();
        }

        public void viszallitGomb_Click(object sender, RoutedEventArgs e)
        {
            int visszaIndex = toroltLb.SelectedIndex;
            feladatok.Add(toroltLb.SelectedItem);
            toroltElemek.RemoveAt(visszaIndex);
            toroltLb.Items.Refresh();
            feladatokLb.Items.Refresh();
        }

        private void vegtorolGomb_Click(object sender, RoutedEventArgs e)
        {
            int veglegTorolIndex = toroltLb.SelectedIndex;
            toroltElemek.RemoveAt(veglegTorolIndex);
            toroltLb.Items.Refresh();
        }
    }
}
