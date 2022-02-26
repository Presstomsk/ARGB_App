using ARGB_App.Model;
using System.Collections.Generic;
using System.Windows.Controls;


namespace ARGB_App.ViewModel
{    
    public class ColorDictionary
    {        
        private Grid _ColorCol { get; set; }
        private ConverterToHex _Converter { get; set; }
        private ColorView _ColorViewOperations { get; set; }        
        private BrushModel _SelectedColor { get; set; }
        public Dictionary<string,BrushModel> Colors { set; get; }
        public ColorDictionary(BrushModel selectedColor, Grid colorCol)
        {
            ElementCounter.Counter = default;
            _ColorCol = colorCol;
            _SelectedColor = selectedColor;
            _Converter = new ConverterToHex();
            _ColorViewOperations = new ColorView(_ColorCol,_Converter);
            Colors = new Dictionary<string,BrushModel>();
            _ColorViewOperations.ButtonDeletePressed += DeleteColor;
        }
        public void AddColor()
        {
            if (!Colors.ContainsKey(_Converter.ConvertToHEX(_SelectedColor)))
            {
                var color = _SelectedColor.Clone();
                Colors.Add(_Converter.ConvertToHEX(color), color);
                _ColorViewOperations.AddColorToScreen(Colors.Count, color, Colors);
                MainWindow.NotButtonEnabled?.Invoke();
            }            
                     
        }      

        public void DeleteColor(string str)
        {
            var subs = str.Split('_');            
            Colors.Remove(subs[1]);
            _ColorViewOperations.UpdateColorOnScreen(Colors);           
        }  
    }
}
