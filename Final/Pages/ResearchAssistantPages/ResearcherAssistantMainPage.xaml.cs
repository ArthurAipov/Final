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
using System.Windows.Threading;

namespace Final.Pages.ResearchAssistantPages
{
    /// <summary>
    /// Interaction logic for ResearcherAssistantMainPage.xaml
    /// </summary>
    public partial class ResearcherAssistantMainPage : Page
    {
        private int time = 0;
        private DispatcherTimer sessionTimer = new DispatcherTimer();
        public ResearcherAssistantMainPage()
        {
            InitializeComponent();
            sessionTimer.Interval = TimeSpan.FromSeconds(1);
            sessionTimer.Tick += SessionTimer_Tick;
            sessionTimer.Start();
        }

        private void SessionTimer_Tick(object sender, EventArgs e)
        {
            time++;
            if (time == 5)
                MessageBox.Show("до завершения сеанса осталось 1 минута");
            if(time == 10)
                NavigationService.GoBack();
            TextBlockTimer.Text = TimeSpan.FromSeconds(10 - time).ToString();
        }
    }
}
