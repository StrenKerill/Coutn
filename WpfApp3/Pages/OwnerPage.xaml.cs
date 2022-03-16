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

namespace WpfApp3.Pages
{
    /// <summary>
    /// Логика взаимодействия для OwnerPage.xaml
    /// </summary>
    public partial class OwnerPage : Page
    {
        public OwnerPage()
        {
            InitializeComponent();
        }

        private void btnAdd(object sender, RoutedEventArgs e)
        {
            var addNum = Window.GetWindow(this) as MainWindow;
            addNum.FrmMain.Navigate(new Pages.AddNumberPage());
        }

        private void btnMul(object sender, RoutedEventArgs e)
        {
            var mulNum = Window.GetWindow(this) as MainWindow;
            mulNum.FrmMain.Navigate(new Pages.MultiplyPage());
        }

        private void btnSub(object sender, RoutedEventArgs e)
        {
            var subNum = Window.GetWindow(this) as MainWindow;
            subNum.FrmMain.Navigate(new Pages.SubtractPage());
        }

        private void btnDiv(object sender, RoutedEventArgs e)
        {
            var divNum = Window.GetWindow(this) as MainWindow;
            divNum.FrmMain.Navigate(new Pages.DividePage());
        }
    }
}
