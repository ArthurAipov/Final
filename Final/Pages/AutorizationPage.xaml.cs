using Final.Models;
using Final.Pages.AccountantPages;
using Final.Pages.AdminPages;
using Final.Pages.LaboratoryAssistantPages;
using Final.Pages.ResearchAssistantPages;
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

namespace Final.Pages
{
    /// <summary>
    /// Interaction logic for AutorizationPage.xaml
    /// </summary>
    public partial class AutorizationPage : Page
    {
        public AutorizationPage()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            var errorMessage = "";
            if (string.IsNullOrWhiteSpace(TextBoxLogin.Text))
                errorMessage += "Enter login \n";
            if (string.IsNullOrWhiteSpace(PasswordBoxPassword.Password))
                errorMessage += "Enter Passsword \n";
            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                MessageBox.Show(errorMessage);
                return;
            }
            var user = GlobalSettings.DB.User.FirstOrDefault(x => x.Password == PasswordBoxPassword.Password && x.Login == TextBoxLogin.Text);
            if (user == null)
            {
                MessageBox.Show("Wrong password or login");
                return;
            }

            GlobalSettings.contextUser = user;

            if (user.RoleId == 1)
            {
                NavigationService.Navigate(new LaboratoryAssistantMainPage());
            }
            if (user.RoleId == 2)
            {
                NavigationService.Navigate(new ResearcherAssistantMainPage());
            }
            if (user.RoleId == 3)
            {
                NavigationService.Navigate(new AccountantMainPage());
            }
            if (user.RoleId == 4)
            {
                NavigationService.Navigate(new AdminMainPage());
            }

        }
    }
}
