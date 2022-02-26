
using ARGB_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ARGB_App.ViewModel
{
    public class ColorViewOperations
    {
        public event ButtonDeletePressedHandler ButtonDeletePressed;
        private Grid _ColorCol { get; set; }
        private ConverterToHex _Converter { get; set; }

        public ColorViewOperations(Grid colorCol, ConverterToHex converter)
        {
            _ColorCol = colorCol;
            _Converter = converter;
        }
        public void AddColorToScreen(int count, BrushModel color, Dictionary<string, BrushModel> colors)
        {
            _ColorCol.ColumnDefinitions.Clear();
            _ColorCol.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(100) });
            _ColorCol.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(350) });
            _ColorCol.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(100) });
            _ColorCol.RowDefinitions.Add(new RowDefinition { Height = new GridLength(50) });
            for (int i = 0; i < 3; i++)
            {
                for (int j = ElementCounter.Counter; j < count; j++)
                {
                    var info = new StackPanel();
                    info.Orientation = Orientation.Horizontal;
                    Grid.SetRow(info, j);
                    Grid.SetColumn(info, i);
                    if (i == 0) info.Children.Add(new Label { Margin = new Thickness(10, 10, 10, 10), MinWidth = 80, Content = $"#{_Converter.ConvertToHEX(color)}" });
                    if (i == 1) info.Children.Add(new TextBlock { Margin = new Thickness(10, 10, 10, 10), MinWidth = 330, MinHeight = 30, Background = colors[_Converter.ConvertToHEX(color)].Brush });
                    if (i == 2) info.Children.Add(new Button { Margin = new Thickness(10, 10, 10, 10), MinWidth = 80, MinHeight = 30, Content = "Delete", Name = $"b_{_Converter.ConvertToHEX(color)}_b" });
                    foreach (var item in info.Children)
                    {
                        if (item is Button)
                        {
                            (item as Button).Click += DeleteButton_Click;
                        }
                    }
                    _ColorCol.Children.Add(info);
                }
            }
            ElementCounter.Counter++;
        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            ButtonDeletePressed?.Invoke((sender as Button).Name);
        }
    }
    
}
