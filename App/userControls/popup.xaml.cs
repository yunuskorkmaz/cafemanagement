using DAL.Models;
using System.Windows.Controls;

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
