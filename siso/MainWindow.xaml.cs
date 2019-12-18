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

namespace siso
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

        private void btnCalcola_Click(object sender, RoutedEventArgs e)
        {
            var birthDay = int.Parse(txtDay.Text);
            var birthMonth = int.Parse(txtMonth.Text);
            var birthYear = int.Parse(txtYear.Text);
            var birthDate = new DateTime(birthYear, birthMonth, birthDay);
            var today = DateTime.Today;
            if (birthDate>today)
            {
                lblResult.Content = "impossibile, non puoi essere nato nel futuro";
            }
            else
            {
                var age = today.Year - birthDate.Year;
                var days = (today - birthDate).TotalDays;
                lblResult.Content = $"hai circa {age} anni e hai esattamente {days} giorni";
            }
        }
    }
}
