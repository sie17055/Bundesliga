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
using System.Windows.Shapes;

namespace Fussball_DB
{
    /// <summary>
    /// Interaction logic for SaveTeamDialog.xaml
    /// </summary>
    public partial class SaveTeamDialog : Window
    {
        verein myVerein;
        string myVereinStadt;
        string myVereinTrainer;
        List<spieler> teamSpieler;
        bundesligaEntities db = new bundesligaEntities();

        public verein MyVerein
        {
            get
            {
                return myVerein;
            }

            set
            {
                myVerein = value;
            }
        }

        public string MyVereinStadt
        {
            get
            {
                return myVereinStadt;
            }

            set
            {
                myVereinStadt = value;
            }
        }

        public string MyVereinTrainer
        {
            get
            {
                return myVereinTrainer;
            }

            set
            {
                myVereinTrainer = value;
            }
        }

        public List<spieler> TeamSpieler
        {
            get
            {
                return teamSpieler;
            }

            set
            {
                teamSpieler = value;
            }
        }

        public SaveTeamDialog(verein myVerein, string myVereinStadt, string myVereinTrainer, List<spieler> teamSpieler)
        {
            InitializeComponent();
            MyVerein = myVerein;
            MyVereinStadt = myVereinStadt;
            MyVereinTrainer = myVereinTrainer;
            vereinsnameBox.Text = MyVerein.Name;
            trainerBox.Text = MyVereinTrainer;
            stadtBox.Text = MyVereinStadt;
            TeamSpieler = teamSpieler;
        }

        private void b_OK_Click(object sender, RoutedEventArgs e)
        {
            MyVerein.spielers = TeamSpieler;
            db.vereins.Add(MyVerein);
            db.SaveChanges();
            DialogResult = true;
        }

        private void b_Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
