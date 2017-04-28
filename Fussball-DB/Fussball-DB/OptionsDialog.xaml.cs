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
    public partial class OptionsDialog : Window
    {
        verein myVerein;
        string myVereinStadt;
        string myVereinTrainer;

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

        public OptionsDialog(verein myVerein, string myVereinStadt, string myVereinTrainer)
        {
            InitializeComponent();
            MyVerein = myVerein;
            MyVereinStadt = myVereinStadt;
            MyVereinTrainer = myVereinTrainer;
        }

        private void b_OK_Click(object sender, RoutedEventArgs e)
        {
            MyVerein.Name = vereinsnameBox.Text;
            MyVereinTrainer = trainerBox.Text;
            MyVereinStadt = stadtBox.Text;
            DialogResult = true;
        }

        private void b_Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
