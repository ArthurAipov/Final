using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace Final.Pages.LaboratoryAssistantPages
{
    /// <summary>
    /// Interaction logic for LaboratoryAssistantMainPage.xaml
    /// </summary>
    public partial class LaboratoryAssistantMainPage : Page
    {
        private int time = 0;
        private DispatcherTimer sessionTimer = new DispatcherTimer();
        public LaboratoryAssistantMainPage()
        {
            InitializeComponent();
            sessionTimer.Interval = TimeSpan.FromMinutes(2);
            sessionTimer.Tick += SessionTimer_Tick;
        }

        private void SessionTimer_Tick(object sender, EventArgs e)
        {
            time++;
            if(time == 60)
                MessageBox.Show("до завершения сеанса осталось 1 минута");
            TextBlockTimer.Text = TimeSpan.FromSeconds(time).ToString();
        }

        private void ButtonAcceptHazardousWaste_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AcceptHazardousWastePage());
        }

        private void ButtonGenerateReports_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
