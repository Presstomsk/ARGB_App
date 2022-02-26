using ARGB_App.Event;
using ARGB_App.Model;
using System.Windows.Controls;

namespace ARGB_App.ViewModel
{    
    public class MyViewModel : MyEvent
    {
        
        private BrushModel _selectedColor;
        public BrushModel SelectedColor
        {
            get { return _selectedColor; }
            set
            {
                if (_selectedColor != value)
                {
                    _selectedColor = value;
                    OnPropertyChanged(nameof(SelectedColor));                    
                }
            }
        }

        public Grid ColorCol { get; set; }
        public ColorDictionary showColor { get; set; }
        public MyViewModel(Grid colorCol)
        {
            ColorCol = colorCol;
            SelectedColor = new BrushModel { Alpha = 0, Red = 0, Green = 0, Blue = 0 };
            showColor = new ColorDictionary(SelectedColor, ColorCol);
            MainWindow.ButtonPressed += showColor.AddColor;

        }
        
    }
}
