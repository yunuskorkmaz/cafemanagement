using DAL.Models;
using Service;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Effects;

namespace cafeManagement.userControls
{
    /// <summary>
    /// Interaction logic for ordersUserControl.xaml
    /// </summary>
    /// 



    public partial class ordersUserControl : UserControl
    {


        public ordersUserControl()
        {
            InitializeComponent();

            popup1.Visibility = Visibility.Hidden;

            
            List<Masa> liste = MasaService.GetList() ;

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
