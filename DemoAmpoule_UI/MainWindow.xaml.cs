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

namespace DemoAmpoule_UI
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChkInterrupteur_Checked(object sender, RoutedEventArgs e)
        {
            imgAmpoule.Source = new BitmapImage(new Uri("pack://application:,,,/on.png"));
        }

        private void ChkInterrupteur_Unchecked(object sender, RoutedEventArgs e)
        {
            imgAmpoule.Source = new BitmapImage(new Uri("pack://application:,,,/off.png"));
        }
    }
}
