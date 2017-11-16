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

namespace cafeManagement.userControls
{
    /// <summary>
    /// Interaction logic for popup.xaml
    /// </summary>
    public partial class popup : UserControl
    {
        
        public Masa SelectedMasa { get; set; }
        public popup(Masa masa)
        {
            
            InitializeComponent();
            SelectedMasa = masa;
            ordersUserControl listelerim = new ordersUserControl();
            listemiz.ItemsSource = listelerim.listemiz.ItemsSource;
            DataContext = this;
        }

       
    }
}
