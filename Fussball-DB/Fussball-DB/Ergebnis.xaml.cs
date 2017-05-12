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

namespace Fussball_DB
{
    /// <summary>
    /// Interaction logic for Ergebnis.xaml
    /// </summary>
    public partial class Ergebnis : UserControl
    {
        bundesligaEntities db = new bundesligaEntities();
        public Ergebnis()
        {
            InitializeComponent();
            comboBox.ItemsSource = from a in db.ligas.ToList()
                                   select new
                                   {
                                       liga = a.Liga_Nr,
                                       verband = a.Verband,
                                       listBox1 = from b in db.vereins
                                                  from c in db.spiels
                                                  where b.Liga == a.Liga_Nr && b.V_ID == c.Heim
                                                  select new
                                                  {
                                                      spieltag = c.Spieltag,
                                                      datum = c.Datum,
                                                      heim = c.Heim,
                                                      gast = c.Gast,
                                                      heimt = c.Tore_Heim,
                                                      gastt = c.Tore_Gast
                                                  }

                                   };
        }

        private void Ausgabe_Click(object sender, RoutedEventArgs e)
        {
            grid.Children.Clear();
            grid.Children.Add(new Ausgabe());
        }

        private void UT_Click(object sender, RoutedEventArgs e)
        {
            grid.Children.Clear();
            grid.Children.Add(new UltimateTeam());
        }

        private void Ergebnis_Click(object sender, RoutedEventArgs e)
        {
            grid.Children.Clear();
            grid.Children.Add(new Ergebnis());
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string liga = System.Convert.ToString(comboBox.SelectedItem);
            Console.WriteLine("***********************************"+liga.Substring(9, 1));
            listBox1.ItemsSource = from a in db.vereins.ToList()
                                   from b in db.spiels.ToList()
                                   from c in db.vereins.ToList()
                                   orderby b.Spieltag
                                   where a.Liga == System.Convert.ToInt32(liga.Substring(9, 1)) && a.V_ID == b.Heim && b.Gast == c.V_ID
                                   select new
                                   {
                                       st=b.Spieltag,
                                       heim = a.Name,
                                       gast = c.Name,
                                       th = b.Tore_Heim,
                                       tg=b.Tore_Gast

            
                                   };



        }
    }
}
