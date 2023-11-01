using Final.AppWindows;
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

namespace Final.Pages.LaboratoryAssistantPages
{
    /// <summary>
    /// Interaction logic for AcceptHazardousWastePage.xaml
    /// </summary>
    public partial class AcceptHazardousWastePage : Page
    {
        public AcceptHazardousWastePage()
        {
            InitializeComponent();
        }

        private void ButtonEnter_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxCode.Text))
            {
                MessageBox.Show("Введите штрихкод");
                return;
            }
            new PDFWindow(TextBoxCode.Text).ShowDialog();

        }
    }
}
