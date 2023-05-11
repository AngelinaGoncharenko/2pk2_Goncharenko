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

namespace pz_29
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenItem_Click(object sender, RoutedEventArgs e)
        {
            OpenWindowItem query = new OpenWindowItem();
            query.Show();
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SkipItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void remItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OutputItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LogOutItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
