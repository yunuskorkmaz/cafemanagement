using MaterialMenu;
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

namespace cafeManagement
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
        userControls.mainPage mainPage = new userControls.mainPage();
        userControls.ordersUserControl ordersUserControl = new userControls.ordersUserControl();
        userControls.authoritiesUserControl authoritiesUserControl = new userControls.authoritiesUserControl();
        userControls.endOfDayOperationsUserControl EndOfDayOperationsUserControl = new userControls.endOfDayOperationsUserControl();
        userControls.menuLayout MenuLayout = new userControls.menuLayout();
        userControls.paymentReportsUserControl PaymentReportsUserControl = new userControls.paymentReportsUserControl();
        userControls.salesReportsUserControl SalesReportsUserControl = new userControls.salesReportsUserControl();
        userControls.stockReportsUserControl StockReportsUserControl = new userControls.stockReportsUserControl();
        userControls.stocksUserControl StocksUserControl = new userControls.stocksUserControl();
        userControls.tableLayoutUserControl TableLayoutUserControl = new userControls.tableLayoutUserControl();
        userControls.userManageUserControl UserManageUserControl = new userControls.userManageUserControl();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            mainContent.Content = mainPage;
        }

        private void menubutton_image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Menu.Toggle();
        }

        private void MenuButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MenuButton clicked = (MenuButton)sender;
            switch (clicked.Tag.ToString())
            {
                case "0":
                    mainContent.Content = mainPage;
                    break;
                case "1":
                    mainContent.Content = ordersUserControl;
                    break;
                case "2":
                    mainContent.Content = TableLayoutUserControl;
                    break;
                case "3":
                    mainContent.Content = MenuLayout;
                    break;
                case "4":
                    mainContent.Content = StocksUserControl;
                    break;
                case "5":
                    mainContent.Content = EndOfDayOperationsUserControl;
                    break;
                case "6":
                    mainContent.Content = SalesReportsUserControl;
                    break;
                case "7":
                    mainContent.Content = PaymentReportsUserControl;
                    break;
                case "8":
                    mainContent.Content = StockReportsUserControl;
                    break;
                case "9":
                    mainContent.Content = UserManageUserControl;
                    break;
                case "10":
                    mainContent.Content = authoritiesUserControl;
                    break;
            }
            Menu.Toggle();
        }
    }
}
