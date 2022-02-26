using ARGB_App.Event;
using ARGB_App.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace ARGB_App.ViewModel
{
    public delegate void IsButtonEnabledHandler();
    public delegate void NotButtonEnabledHandler();
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
        public ColorOperations showColor { get; set; }
        public MyViewModel(Grid colorCol)
        {
            ColorCol = colorCol;
            SelectedColor = new BrushModel { Alpha = 0, Red = 0, Green = 0, Blue = 0 };
            showColor = new ColorOperations(SelectedColor, ColorCol);
            MainWindow.ButtonPressed += showColor.AddColor;

        }
        
    }
}
