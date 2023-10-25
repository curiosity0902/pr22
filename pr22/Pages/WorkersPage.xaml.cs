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
using pr22.DB;
using pr22.Windows;

namespace pr22.Pages
{
    /// <summary>
    /// Логика взаимодействия для WorkersPage.xaml
    /// </summary>
    public partial class WorkersPage : Page
    {
        public WorkersPage()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WorkerWindow());
        }

        private void WorkersLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Worker worker = WorkersLv.SelectedItem as Worker;
            //WorkerWindow workerWindow = new WorkerWindow(worker);
            //workerWindow.Show();
        }
    }
}
