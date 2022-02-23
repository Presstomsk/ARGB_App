using ARGB_App.Model;
using ARGB_App.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace ARGB_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

   
    public partial class MainWindow : Window
    {
        public static ButtonPressedHandler ButtonPressed;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MyViewModel();            
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ButtonPressed?.Invoke(ColorCol);
        }
        


    }
}
