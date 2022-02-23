using ARGB_App.Event;
using ARGB_App.Model;
using System.Collections.ObjectModel;



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
        public ObservableCollection<BrushModel> Colors { set; get; }

        public MyViewModel()
        {
            Colors = new ObservableCollection<BrushModel>();
            SelectedColor = new BrushModel { Alpha = 0, Red = 0, Green = 0, Blue = 0 };
        }
        
    }
}
