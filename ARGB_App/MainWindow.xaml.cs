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
        public static ButtonAddPressedHandler ButtonPressed;
        public static IsButtonEnabledHandler IsButtonEnabled;
        public static NotButtonEnabledHandler NotButtonEnabled; 

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MyViewModel(ColorCol);
            IsButtonEnabled += IsEnable;
            NotButtonEnabled += NotEnable;
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ButtonPressed?.Invoke();            

        }

        private void IsEnable()
        {
            AddBut.IsEnabled = true;
        }
        private void NotEnable()
        {
            AddBut.IsEnabled = false;
        }



        

    }
}
