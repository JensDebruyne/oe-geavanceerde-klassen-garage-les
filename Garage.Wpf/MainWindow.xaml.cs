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
using AutoBeheer.Lib.Entities;
using AutoBeheer.Lib.Services;

namespace Garage.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AutoManagement minOttos;
        

        public MainWindow()
        {
            InitializeComponent();
            minOttos = new AutoManagement(true);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            KoppelVariabeleLijsten();
            KoppelVasteLijsten();
        }

        void KoppelVariabeleLijsten()
        {
            lstAutos.ItemsSource = minOttos.Autos;
            lstAutos.Items.Refresh();
        }

        void KoppelVasteLijsten()
        {

        }

        void KoppelBijkomendeInfo(Type autoType)
        {
            cmbBijkomendeInfo.Items.Clear();

        }

        void ToonDetails(Auto auto)
        {

        }

        private void lstAutos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            if(lstAutos.SelectedItem != null)
            {
                Auto huidigeAuto;
                huidigeAuto = (Auto)lstAutos.SelectedItem;
                ToonDetails(huidigeAuto);
            }

        }
    }
}
