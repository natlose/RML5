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

namespace RML_Validation
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

        private void Keres_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindowVM)DataContext).LoadData();
        }

        private void Elvet_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindowVM)DataContext).LoadData();
        }

        private void CimTorol_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindowVM)DataContext).RemoveAddress((Address)AddressList.SelectedItem);
        }

        private void Rogzit_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindowVM)DataContext).SaveData();
        }
    }
}
