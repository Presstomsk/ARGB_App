using ARGB_App.Event;
using System.Windows.Media;


namespace ARGB_App.Model
{
    public class BrushModel : MyEvent
    {
        private Brush _brush;
        private byte _alpha;
        private byte _red;
        private byte _green;
        private byte _blue;

        public Brush Brush
        {
            get { return _brush; }
            set
            {
                if (_brush != value)
                {
                    _brush = value;
                    OnPropertyChanged(nameof(Brush));
                }
            }
        }
        public byte Alpha
        {
            get { return _alpha; }
            set
            {
                if (_alpha != value)
                {
                    _alpha = value;
                    OnPropertyChanged(nameof(Alpha));
                }
            }
        }
        public byte Red
        {
            get { return _red; }
            set
            {
                if (_red != value)
                {
                    _red = value;
                    OnPropertyChanged(nameof(Red));
                }
            }
        }
        public byte Green
        {
            get { return _green; }
            set
            {
                if (_green != value)
                {
                    _green = value;
                    OnPropertyChanged(nameof(Green));
                }
            }
        }
        public byte Blue
        {
            get { return _blue; }
            set
            {
                if (_blue != value)
                {
                    _blue = value;
                    OnPropertyChanged(nameof(Blue));
                }
            }
        }

        public BrushModel()
        {
            this.PropertyChanged += MyColor_PropertyChanged;
        }

        private void MyColor_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Alpha" || e.PropertyName == "Red" || e.PropertyName == "Blue" || e.PropertyName == "Green")
                Brush = new SolidColorBrush(Color.FromArgb(Alpha, Red, Green, Blue));
        }

        

        

    }
}
