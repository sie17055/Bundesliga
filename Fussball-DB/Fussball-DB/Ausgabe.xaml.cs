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
    /// Interaction logic for Ausgabe.xaml
    /// </summary>
    public partial class Ausgabe : UserControl
    {
        string spieler = "";
        string verein = "";
        bundesligaEntities db = new bundesligaEntities();
        public Ausgabe()
        {
            InitializeComponent();
            listBox.ItemsSource = from a in db.vereins.ToList()
                      select new
                      {
                          Name = a.Name
                      };
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string verein = System.Convert.ToString(listBox.SelectedItem);
            listBox1.ItemsSource = (from b in db.spielers.ToList()
                       from c in db.vereins.ToList()
                       where verein != c.Name /*&& c.V_ID == b.Vereins_ID*/
                       select new
                       {
                           Spielername = b.Spieler_Name
                       }).Distinct();

            /*List<spieler> l = new List<spieler>();
            string suchbegriff = System.Convert.ToString(listBox.SelectedItem);
            Console.WriteLine(suchbegriff.Substring(9, suchbegriff.Length - 11) + "**********************************************************************");
            var liste = from x in db.spielers
                        where x.verein.Name.Contains(suchbegriff.Substring(9, suchbegriff.Length - 11))
                        select x;
            l = liste.ToList();
            listBox1.ItemsSource = l;*/

        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string spieler = System.Convert.ToString(listBox1.SelectedItem);
            /*textBox.Text = from c in db.spielers
                      where c.Spieler_Name == spieler
                      select new
                      {
                          name = c.Spieler_Name
                      };
            textBox1 = from d in db.spielers
                       from e in db.vereins
                       where d.Spieler_Name == spieler && d.Vereins_ID == e.V_ID
                       select new
                       {
                           verein = e.Name
                       };
            textBox2 = from f in db.spielers
                       where f.Spieler_Name == spieler
                       select new
                       {
                           nummer = f.Trikot_Nr
                       };
            textBox3 = from g in db.spielers
                       where g.Spieler_Name == spieler
                       select new
                       {
                           land = g.Land
                       };*/
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
    }
}
