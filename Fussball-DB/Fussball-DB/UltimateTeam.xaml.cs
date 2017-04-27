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
    /// Interaction logic for UltimateTeam.xaml
    /// </summary>
    public partial class UltimateTeam : UserControl
    {
        List<object> spieler;
        bundesligaEntities db = new bundesligaEntities();
        spieler selected;
        public List<object> Spieler
        {
            get
            {
                return spieler;
            }

            set
            {
                spieler = value;
            }
        }

        public spieler Selected
        {
            get
            {
                return selected;
            }

            set
            {
                selected = value;
            }
        }

        public UltimateTeam()
        {
            InitializeComponent();
            Spieler = new List<object>();
            listBox1.ItemsSource = db.spielers.ToList();            
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            SaveTeamDialog stDialog = new SaveTeamDialog();
            stDialog.Show();
        }

        private void b_Aufstellung_Click(object sender, RoutedEventArgs e)
        {
            aufstellung.Source = vorschau.Source;
        }

        private void spielerDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Spieler.Add(Selected);
            if (!listBox2.Items.Contains(Selected))
            {
                listBox2.Items.Add(Selected);
            }
        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = (ListBox)sender;
            Selected = (spieler)a.SelectedItem;
        }

        private void teamDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Spieler.Add(Selected);
            listBox2.Items.Remove(Selected);
        }

        private void teamSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var b = (ListBox)sender;
            Selected = (spieler)b.SelectedItem;
        }

        private void button1_Click(object sender, RoutedEventArgs e) //Name
        {
            List<spieler> l = new List<spieler>();
            string suchbegriff = textBox1.Text;
            var liste = from x in db.spielers
                        where x.Spieler_Name.Contains(suchbegriff)
                        select x;
            l = liste.ToList();
            listBox1.ItemsSource = l;
}

        private void button2_Click(object sender, RoutedEventArgs e) //Verein
        {
            List<spieler> l = new List<spieler>();
            string suchbegriff = textBox2.Text;
            var liste = from x in db.spielers
                        where x.verein.Name.Contains(suchbegriff)
                        select x;
            l = liste.ToList();
            listBox1.ItemsSource = l;
        }

        private void button3_Click(object sender, RoutedEventArgs e) //Nationalität
        {
            List<spieler> l = new List<spieler>();
            string suchbegriff = textBox3.Text;
            var liste = from x in db.spielers
                        where x.Land.Contains(suchbegriff)
                        select x;
            l = liste.ToList();
            listBox1.ItemsSource = l;
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
    }
}
