using System;
using System.Collections;
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
        List<spieler> spieler;
        bundesligaEntities db = new bundesligaEntities();
        spieler selected;
        ListBox dragSource = null;
        spieler sTW = null;
        spieler sRB = null;
        spieler sCDL = null;
        spieler sCDR = null;
        spieler sLB = null;
        spieler sLM = null;
        spieler sLM2 = null;
        spieler sDM = null;
        spieler sCML = null;
        spieler sCMM = null;
        spieler sCMR = null;
        spieler sRM2 = null;
        spieler sRM = null;
        spieler sAMCL = null;
        spieler sAMCM = null;
        spieler sAMCR = null;
        spieler sLW = null;
        spieler sSTL = null;
        spieler sSTM = null;
        spieler sSTR = null;
        spieler sRW = null;
        SpielerInfoDialog siDialog = null;
        verein myVerein = new verein();
        string myVereinTrainer = "Max Mustermann";
        string myVereinStadt = "Musterstadt";
        public List<spieler> Spieler
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
            Spieler = new List<spieler>();
            listBox1.ItemsSource = db.spielers.ToList();
            myVerein.Liga = 1;
            myVerein.Name = "1.FC Muster";
            myVerein.V_ID = db.vereins.Count() + 1;
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            SaveTeamDialog stDialog = new SaveTeamDialog(myVerein, myVereinStadt, myVereinTrainer, (List<spieler>)listBox2.ItemsSource);
            stDialog.ShowDialog();
        }

        private void b_Aufstellung_Click(object sender, RoutedEventArgs e)
        {
            aufstellung.Source = vorschau.Source;
            tw.IsEnabled = true;
            tw.Visibility = Visibility.Visible;
            lb.IsEnabled = true;
            lb.Visibility = Visibility.Visible;
            cd_l.IsEnabled = true;
            cd_l.Visibility = Visibility.Visible;
            cd_r.IsEnabled = true;
            cd_r.Visibility = Visibility.Visible;
            rb.IsEnabled = true;
            rb.Visibility = Visibility.Visible;
            if (comboBox.SelectedIndex == 0)
            {
                lm.IsEnabled = true;
                lm.Visibility = Visibility.Visible;
                cm_l.IsEnabled = true;
                cm_l.Visibility = Visibility.Visible;
                cm_r.IsEnabled = true;
                cm_r.Visibility = Visibility.Visible;
                rm.IsEnabled = true;
                rm.Visibility = Visibility.Visible;
                st_l.IsEnabled = true;
                st_l.Visibility = Visibility.Visible;
                st_r.IsEnabled = true;
                st_r.Visibility = Visibility.Visible;
                //...
                lm_2.IsEnabled = false;
                lm_2.Visibility = Visibility.Hidden;
                cm_m.IsEnabled = false;
                cm_m.Visibility = Visibility.Hidden;
                rm_2.IsEnabled = false;
                rm_2.Visibility = Visibility.Hidden;
                lw.IsEnabled = false;
                lw.Visibility = Visibility.Hidden;
                st_m.IsEnabled = false;
                st_m.Visibility = Visibility.Hidden;
                rw.IsEnabled = false;
                rw.Visibility = Visibility.Hidden;
                amc_l.IsEnabled = false;
                amc_l.Visibility = Visibility.Hidden;
                amc_m.IsEnabled = false;
                amc_m.Visibility = Visibility.Hidden;
                amc_r.IsEnabled = false;
                amc_r.Visibility = Visibility.Hidden;
                dm.IsEnabled = false;
                dm.Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 1)
            {
                lm_2.IsEnabled = true;
                lm_2.Visibility = Visibility.Visible;
                cm_m.IsEnabled = true;
                cm_m.Visibility = Visibility.Visible;
                rm_2.IsEnabled = true;
                rm_2.Visibility = Visibility.Visible;
                lw.IsEnabled = true;
                lw.Visibility = Visibility.Visible;
                st_m.IsEnabled = true;
                st_m.Visibility = Visibility.Visible;
                rw.IsEnabled = true;
                rw.Visibility = Visibility.Visible;
                //...
                lm.IsEnabled = false;
                lm.Visibility = Visibility.Hidden;
                cm_l.IsEnabled = false;
                cm_l.Visibility = Visibility.Hidden;
                cm_r.IsEnabled = false;
                cm_r.Visibility = Visibility.Hidden;
                rm.IsEnabled = false;
                rm.Visibility = Visibility.Hidden;
                st_l.IsEnabled = false;
                st_l.Visibility = Visibility.Hidden;
                st_r.IsEnabled = false;
                st_r.Visibility = Visibility.Hidden;
                amc_l.IsEnabled = false;
                amc_l.Visibility = Visibility.Hidden;
                amc_m.IsEnabled = false;
                amc_m.Visibility = Visibility.Hidden;
                amc_r.IsEnabled = false;
                amc_r.Visibility = Visibility.Hidden;
                dm.IsEnabled = false;
                dm.Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 2)
            {
                lm_2.IsEnabled = true;
                lm_2.Visibility = Visibility.Visible;
                cm_m.IsEnabled = true;
                cm_m.Visibility = Visibility.Visible;
                rm_2.IsEnabled = true;
                rm_2.Visibility = Visibility.Visible;
                amc_l.IsEnabled = true;
                amc_l.Visibility = Visibility.Visible;
                amc_r.IsEnabled = true;
                amc_r.Visibility = Visibility.Visible;
                st_m.IsEnabled = true;
                st_m.Visibility = Visibility.Visible;
                //...
                lm.IsEnabled = false;
                lm.Visibility = Visibility.Hidden;
                cm_l.IsEnabled = false;
                cm_l.Visibility = Visibility.Hidden;
                cm_r.IsEnabled = false;
                cm_r.Visibility = Visibility.Hidden;
                rm.IsEnabled = false;
                rm.Visibility = Visibility.Hidden;
                amc_m.IsEnabled = false;
                amc_m.Visibility = Visibility.Hidden;
                dm.IsEnabled = false;
                dm.Visibility = Visibility.Hidden;
                st_l.IsEnabled = false;
                st_l.Visibility = Visibility.Hidden;
                st_r.IsEnabled = false;
                st_r.Visibility = Visibility.Hidden;
                rw.IsEnabled = false;
                rw.Visibility = Visibility.Hidden;
                lw.IsEnabled = false;
                lw.Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 3)
            {
                dm.IsEnabled = true;
                dm.Visibility = Visibility.Visible;
                lm.IsEnabled = true;
                lm.Visibility = Visibility.Visible;
                rm.IsEnabled = true;
                rm.Visibility = Visibility.Visible;
                amc_m.IsEnabled = true;
                amc_m.Visibility = Visibility.Visible;
                st_l.IsEnabled = true;
                st_l.Visibility = Visibility.Visible;
                st_r.IsEnabled = true;
                st_r.Visibility = Visibility.Visible;
                //...
                lm_2.IsEnabled = false;
                lm_2.Visibility = Visibility.Hidden;
                rm_2.IsEnabled = false;
                rm_2.Visibility = Visibility.Hidden;
                amc_l.IsEnabled = false;
                amc_l.Visibility = Visibility.Hidden;
                amc_r.IsEnabled = false;
                amc_r.Visibility = Visibility.Hidden;
                st_m.IsEnabled = false;
                st_m.Visibility = Visibility.Hidden;
                cm_l.IsEnabled = false;
                cm_l.Visibility = Visibility.Hidden;
                cm_m.IsEnabled = false;
                cm_m.Visibility = Visibility.Hidden;
                cm_r.IsEnabled = false;
                cm_r.Visibility = Visibility.Hidden;
                lw.IsEnabled = false;
                lw.Visibility = Visibility.Hidden;
                rw.IsEnabled = false;
                rw.Visibility = Visibility.Hidden;
            }
        }

        private void spielerDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Spieler.Add(Selected);
            if (listBox2.Items.Count < 11 && !listBox2.Items.Contains(Selected))
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

        private void cm_l_Click(object sender, RoutedEventArgs e)
        {
            siDialog = new SpielerInfoDialog(sCML);
            siDialog.ShowDialog();
        }

        private void tw_Click(object sender, RoutedEventArgs e)
        {
            siDialog = new SpielerInfoDialog(sTW);
            siDialog.ShowDialog();
        }

        private void lb_Click(object sender, RoutedEventArgs e)
        {
            siDialog = new SpielerInfoDialog(sLB);
            siDialog.ShowDialog();
        }

        private void cd_l_Click(object sender, RoutedEventArgs e)
        {
            siDialog = new SpielerInfoDialog(sCDL);
            siDialog.ShowDialog();
        }

        private void cd_r_Click(object sender, RoutedEventArgs e)
        {
            siDialog = new SpielerInfoDialog(sCDR);
            siDialog.ShowDialog();
        }

        private void rb_Click(object sender, RoutedEventArgs e)
        {
            siDialog = new SpielerInfoDialog(sRB);
            siDialog.ShowDialog();
        }

        private void dm_Click(object sender, RoutedEventArgs e)
        {
            siDialog = new SpielerInfoDialog(sDM);
            siDialog.ShowDialog();
        }

        private void lm_Click(object sender, RoutedEventArgs e)
        {
            siDialog = new SpielerInfoDialog(sLM);
            siDialog.ShowDialog();
        }

        private void lm_2_Click(object sender, RoutedEventArgs e)
        {
            siDialog = new SpielerInfoDialog(sLM2);
            siDialog.ShowDialog();
        }

        private void cm_m_Click(object sender, RoutedEventArgs e)
        {
            siDialog = new SpielerInfoDialog(sCMM);
            siDialog.ShowDialog();
        }

        private void cm_r_Click(object sender, RoutedEventArgs e)
        {
            siDialog = new SpielerInfoDialog(sCMR);
            siDialog.ShowDialog();
        }

        private void rm_2_Click(object sender, RoutedEventArgs e)
        {
            siDialog = new SpielerInfoDialog(sRM2);
            siDialog.ShowDialog();
        }

        private void rm_Click(object sender, RoutedEventArgs e)
        {
            siDialog = new SpielerInfoDialog(sRM);
            siDialog.ShowDialog();
        }

        private void amc_l_Click(object sender, RoutedEventArgs e)
        {
            siDialog = new SpielerInfoDialog(sAMCL);
            siDialog.ShowDialog();
        }

        private void amc_m_Click(object sender, RoutedEventArgs e)
        {
            siDialog = new SpielerInfoDialog(sAMCM);
            siDialog.ShowDialog();
        }

        private void amc_r_Click(object sender, RoutedEventArgs e)
        {
            siDialog = new SpielerInfoDialog(sAMCR);
            siDialog.ShowDialog();
        }

        private void lw_Click(object sender, RoutedEventArgs e)
        {
            siDialog = new SpielerInfoDialog(sLW);
            siDialog.ShowDialog();
        }

        private void st_l_Click(object sender, RoutedEventArgs e)
        {
            siDialog = new SpielerInfoDialog(sSTL);
            siDialog.ShowDialog();
        }

        private void st_m_Click(object sender, RoutedEventArgs e)
        {
            siDialog = new SpielerInfoDialog(sSTM);
            siDialog.ShowDialog();
        }

        private void st_r_Click(object sender, RoutedEventArgs e)
        {
            siDialog = new SpielerInfoDialog(sSTR);
            siDialog.ShowDialog();
        }

        private void rw_Click(object sender, RoutedEventArgs e)
        {
            siDialog = new SpielerInfoDialog(sRW);
            siDialog.ShowDialog();
        }

        private void ListBox_PreviewMouseLBD(object sender, MouseButtonEventArgs e)
        {
            ListBox parent = (ListBox)sender;
            dragSource = parent;
            object data = GetDataFromListBox(dragSource, e.GetPosition(parent));

            if (data != null)
            {
                DragDrop.DoDragDrop(parent, ((spieler)data).Spieler_ID, DragDropEffects.Move);
            }
        }
        #region GetDataFromListBox(ListBox,Point)
        private static object GetDataFromListBox(ListBox source, Point point)
        {
            UIElement element = source.InputHitTest(point) as UIElement;
            if (element != null)
            {
                object data = DependencyProperty.UnsetValue;
                while (data == DependencyProperty.UnsetValue)
                {
                    data = source.ItemContainerGenerator.ItemFromContainer(element);

                    if (data == DependencyProperty.UnsetValue)
                    {
                        element = VisualTreeHelper.GetParent(element) as UIElement;
                    }

                    if (element == source)
                    {
                        return null;
                    }
                }

                if (data != DependencyProperty.UnsetValue)
                {
                    return data;
                }
            }

            return null;
        }

        #endregion

        private void tw_Drop(object sender, DragEventArgs e)
        {
            IDataObject id = e.Data;
            int data = (int)(id.GetData(typeof(int)));
            sTW = getSpieler(db, data);
        }

        private static spieler getSpieler(bundesligaEntities db, int id)
        {
            List<spieler> alleSpieler = db.spielers.ToList();
            int spielerID = id;
            spieler s = alleSpieler.ElementAt(id-1);
            return s;
        }

        private void lb_Drop(object sender, DragEventArgs e)
        {
            IDataObject id = e.Data;
            int data = (int)(id.GetData(typeof(int)));
            sLB = getSpieler(db, data);
            Console.WriteLine(sLB.Spieler_Name + "**************************************************************");
        }

        private void cd_l_Drop(object sender, DragEventArgs e)
        {
            IDataObject id = e.Data;
            int data = (int)(id.GetData(typeof(int)));
            sCDL = getSpieler(db, data);
        }

        private void cd_r_Drop(object sender, DragEventArgs e)
        {
            IDataObject id = e.Data;
            int data = (int)(id.GetData(typeof(int)));
            sCDR = getSpieler(db, data);
        }

        private void rb_Drop(object sender, DragEventArgs e)
        {
            IDataObject id = e.Data;
            int data = (int)(id.GetData(typeof(int)));
            sRB = getSpieler(db, data);
        }

        private void dm_Drop(object sender, DragEventArgs e)
        {
            IDataObject id = e.Data;
            int data = (int)(id.GetData(typeof(int)));
            sDM = getSpieler(db, data);
        }

        private void lm_Drop(object sender, DragEventArgs e)
        {
            IDataObject id = e.Data;
            int data = (int)(id.GetData(typeof(int)));
            sLM = getSpieler(db, data);
        }

        private void lm_2_Drop(object sender, DragEventArgs e)
        {
            IDataObject id = e.Data;
            int data = (int)(id.GetData(typeof(int)));
            sLM2 = getSpieler(db, data);
        }

        private void cm_l_Drop(object sender, DragEventArgs e)
        {
            IDataObject id = e.Data;
            int data = (int)(id.GetData(typeof(int)));
            sCML = getSpieler(db, data);
        }

        private void cm_m_Drop(object sender, DragEventArgs e)
        {
            IDataObject id = e.Data;
            int data = (int)(id.GetData(typeof(int)));
            sCMM = getSpieler(db, data);
        }

        private void cm_r_Drop(object sender, DragEventArgs e)
        {
            IDataObject id = e.Data;
            int data = (int)(id.GetData(typeof(int)));
            sCMR = getSpieler(db, data);
        }

        private void rm_2_Drop(object sender, DragEventArgs e)
        {
            IDataObject id = e.Data;
            int data = (int)(id.GetData(typeof(int)));
            sRM2 = getSpieler(db, data);
        }

        private void rm_Drop(object sender, DragEventArgs e)
        {
            IDataObject id = e.Data;
            int data = (int)(id.GetData(typeof(int)));
            sRM = getSpieler(db, data);
        }

        private void amc_l_Drop(object sender, DragEventArgs e)
        {
            IDataObject id = e.Data;
            int data = (int)(id.GetData(typeof(int)));
            sAMCL = getSpieler(db, data);
        }

        private void amc_m_Drop(object sender, DragEventArgs e)
        {
            IDataObject id = e.Data;
            int data = (int)(id.GetData(typeof(int)));
            sAMCM = getSpieler(db, data);
        }

        private void amc_r_Drop(object sender, DragEventArgs e)
        {
            IDataObject id = e.Data;
            int data = (int)(id.GetData(typeof(int)));
            sAMCR = getSpieler(db, data);
        }

        private void lw_Drop(object sender, DragEventArgs e)
        {
            IDataObject id = e.Data;
            int data = (int)(id.GetData(typeof(int)));
            sLW = getSpieler(db, data);
        }

        private void st_l_Drop(object sender, DragEventArgs e)
        {
            IDataObject id = e.Data;
            int data = (int)(id.GetData(typeof(int)));
            sSTL = getSpieler(db, data);
        }

        private void st_m_Drop(object sender, DragEventArgs e)
        {
            IDataObject id = e.Data;
            int data = (int)(id.GetData(typeof(int)));
            sSTM = getSpieler(db, data);
        }

        private void st_r_Drop(object sender, DragEventArgs e)
        {
            IDataObject id = e.Data;
            int data = (int)(id.GetData(typeof(int)));
            sSTR = getSpieler(db, data);
        }

        private void rw_Drop(object sender, DragEventArgs e)
        {
            IDataObject id = e.Data;
            int data = (int)(id.GetData(typeof(int)));
            sRW = getSpieler(db, data);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void options_Click(object sender, RoutedEventArgs e)
        {
            OptionsDialog optionsD = new OptionsDialog(myVerein, myVereinStadt, myVereinTrainer);
            optionsD.ShowDialog();
            myVerein = optionsD.MyVerein;
            myVereinStadt = optionsD.MyVereinStadt;
            myVereinTrainer = optionsD.MyVereinTrainer;
        }
    }
}

