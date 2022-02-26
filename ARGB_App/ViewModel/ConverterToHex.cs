using ARGB_App.Model;
using System;


namespace ARGB_App.ViewModel
{
    public class ConverterToHex
    {
        public string ConvertToHEX(BrushModel selectedColor)
        {
            return $"{Convert.ToInt32(selectedColor.Alpha).ToString("X")}{Convert.ToInt32(selectedColor.Red).ToString("X")}{Convert.ToInt32(selectedColor.Green).ToString("X")}{Convert.ToInt32(selectedColor.Blue).ToString("X")}";
        }
    }
}
