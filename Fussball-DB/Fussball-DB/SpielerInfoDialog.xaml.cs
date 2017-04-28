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
    /// Interaction logic for SpielerInfoDialog.xaml
    /// </summary>
    public partial class SpielerInfoDialog : Window
    {
        spieler s;
        public SpielerInfoDialog(spieler s)
        {
            InitializeComponent();
            S = s;
            nameBox.Text = S.Spieler_Name;
            vereinBox.Text = S.verein.Name;
            nationalitaetBox.Text = S.Land;
        }

        public spieler S
        {
            get
            {
                return s;
            }

            set
            {
                s = value;
            }
        }
    }
}
