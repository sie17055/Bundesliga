﻿using System;
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
        bundesligaEntities db = new bundesligaEntities();
        public UltimateTeam()
        {
            InitializeComponent();
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
    }
}
