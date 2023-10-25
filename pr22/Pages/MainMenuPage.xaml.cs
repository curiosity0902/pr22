using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Claims;
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

namespace pr22.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainMenuPage.xaml
    /// </summary>
    public partial class MainMenuPage : Page
    {
        public static List<Worker> workers { get; set; }
  
        public MainMenuPage()
        {
            InitializeComponent();
            workers = new List<Worker>
               (DBConnection.slippersProdactionEntities.Worker.ToList());
        
        }

        private void WorkersBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WorkersPage());
        }

        private void PlanBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
