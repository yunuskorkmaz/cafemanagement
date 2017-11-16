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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cafeManagement.userControls
{
    /// <summary>
    /// Interaction logic for ordersUserControl.xaml
    /// </summary>
    /// 

    public class Masa
    {
        public string Adi { get; set; }
        public int additionCount { get; set; }
    }

    public partial class ordersUserControl : UserControl
    {


        public ordersUserControl()
        {
            InitializeComponent();

            popup1.Visibility = Visibility.Hidden;
            List<Masa> liste = new List<Masa>()
            {
                new Masa(){Adi= "BÜLENT FIRAT",additionCount=123},
                new Masa(){ Adi = "Masa 2",additionCount=45},
                 new Masa(){Adi= "Masa 1",additionCount=55},
                new Masa(){ Adi = "Masa 2",additionCount=45645678},
                 new Masa(){Adi= "Masa 1",additionCount=5},
                new Masa(){ Adi = "Masa 2",additionCount=2},
                 new Masa(){Adi= "Masa 1",additionCount=2},
                new Masa(){ Adi = "Masa 2",additionCount=5},
                new Masa(){Adi= "Masa 1",additionCount=5},
                new Masa(){ Adi = "Masa 2",additionCount=5},
                 new Masa(){Adi= "Masa 1",additionCount=5},
                new Masa(){ Adi = "Masa 2",additionCount=844916645},
                 new Masa(){Adi= "Masa 1",additionCount=5},
                new Masa(){ Adi = "Masa 2",additionCount=5},
                 new Masa(){Adi= "Masa 1",additionCount=5},
                new Masa(){ Adi = "Masa 2",additionCount=5},
                 new Masa(){Adi= "Masa 1",additionCount=5},
                new Masa(){ Adi = "Masa 2",additionCount=5},
                 new Masa(){Adi= "Masa 1",additionCount=5},
                new Masa(){ Adi = "Masa 2",additionCount=5},
                 new Masa(){Adi= "Masa 1",additionCount=5},
                new Masa(){ Adi = "Masa 2",additionCount=5},
                 new Masa(){Adi= "Masa 1",additionCount=5},
                new Masa(){ Adi = "Masa 2",additionCount=5},
                 new Masa(){Adi= "Masa 1",additionCount=5},
                new Masa(){ Adi = "Masa 2",additionCount=5},
                 new Masa(){Adi= "Masa 1",additionCount=5},
                new Masa(){ Adi = "Masa 2",additionCount=5},
                 new Masa(){Adi= "TEST 1"},
                new Masa(){ Adi = "Masa 2"},
                 new Masa(){Adi= "Masa 1"},
                new Masa(){ Adi = "Masa 2"},
                 new Masa(){Adi= "Masa 1"},
                new Masa(){ Adi = "Masa 2"}

            };

            listemiz.ItemsSource = liste;

            listemiz.SelectionChanged += Listemiz_SelectionChanged;



        }


        BlurBitmapEffect doBlur = new BlurBitmapEffect();

        private void Listemiz_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            popup1.Children.Clear();
            Masa a = listemiz.SelectedItem as Masa;

            var popupaaa = new popup(a);


            popup1.Children.Add(popupaaa);
            popup1.Visibility = Visibility.Visible;

            popupaaa.backButton.MouseDown += BackButton_MouseDown;

            mainGridOrders.IsEnabled = false;
            doBlur.Radius = 4;
            mainGridOrders.BitmapEffect = doBlur;


        }

        private void BackButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            popup1.Children.Clear();
            mainGridOrders.IsEnabled = true;
            doBlur.Radius = 0;
            mainGridOrders.BitmapEffect = doBlur;
        }

        //BlurBitmapEffect doBlur = new BlurBitmapEffect();
        //private void masa1_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    Panel.SetZIndex(orderAndPaymentGrid, 1000);
        //    mainGridOrders.IsEnabled = false;
        //    doBlur.Radius = 4;
        //    mainGridOrders.BitmapEffect = doBlur;
        //}

        //private void backButton_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    Panel.SetZIndex(orderAndPaymentGrid, -1);
        //    mainGridOrders.IsEnabled = true;
        //    doBlur.Radius = 0;
        //    mainGridOrders.BitmapEffect = doBlur;
        //}

        private void WrapPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
