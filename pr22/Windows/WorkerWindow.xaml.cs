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

namespace pr22.Windows
{
    /// <summary>
    /// Логика взаимодействия для WorkerWindow.xaml
    /// </summary>
    public partial class WorkerWindow : Window
    {
        //public static List<Worker> worker { get; set; }
        public WorkerWindow()
        {
            InitializeComponent();

        }

        private void WriteBtn_Click(object sender, RoutedEventArgs e)
        {
            var dcvd = SurnameTb.Text + " " + NameTb.Text + " " + PatronymicTb.Text + " " + DateDp.SelectedDate + " " + PassportTb.Text + " " + PhoneTb.Text;

            //if (MessageBox.Show(dcvd, "Проверьте корректность введенных данных", MessageBoxButton.YesNoCancel) == MessageBoxResult.Yes)
            //{
            //    Worker worker = new Worker();

            //    worker.Surname = SurnameTb.Text.Trim();
            //    worker.Name = NameTb.Text.Trim();
            //    worker.Patronymic = PatronymicTb.Text.Trim();
            //    worker.DateOfBirth = DateDp.SelectedDate;
            //    worker.Passport = PassportTb.Text.Trim();
            //    worker.Phone = PhoneTb.Text.Trim();
            //    //worker. = EmailTb.Text.Trim();

            //    DBConnection.slippersProdactionEntities.Worker.Add(worker);
            //    DBConnection.slippersProdactionEntities.SaveChanges();

            //    WorkersLv.ItemsSource = new List<Worker>(DBConnection.slippersProdactionEntities.Worker.ToList());
            //}

        }
    }
}
