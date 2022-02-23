
using ARGB_App.Model;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ARGB_App.ViewModel
{
    public delegate void ButtonPressedHandler(Grid colorCol);
    public class ShowColor
    {
        private int _counter;
        private BrushModel _SelectedColor { get; set; }
        public ObservableCollection<BrushModel> Colors { set; get; }
        public ShowColor(BrushModel selectedColor)
        {
            _SelectedColor = selectedColor;
            Colors = new ObservableCollection<BrushModel>();
        }
        public void InitColorCollection(Grid ColorCol)
        {
            Colors.Add(_SelectedColor);
            ColorCol.ColumnDefinitions.Clear();
            ColorCol.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(100) });
            ColorCol.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(350) });
            ColorCol.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(100) });
            ColorCol.RowDefinitions.Add(new RowDefinition { Height = new GridLength(50) });
            for (int i = 0; i < 3; i++)
            {
                for (int j = _counter; j < Colors.Count; j++)
                {
                    var info = new StackPanel();
                    info.Orientation = Orientation.Horizontal;
                    Grid.SetRow(info, j);
                    Grid.SetColumn(info, i);
                    if (i == 0) info.Children.Add(new Label { Margin = new Thickness(10, 10, 10, 10), MinWidth = 80, Content = Colors.Count.ToString() });
                    if (i == 1) info.Children.Add(new TextBlock { Margin = new Thickness(10, 10, 10, 10), MinWidth = 330, MinHeight = 30, Background = Colors[j].Brush });
                    if (i == 2) info.Children.Add(new Button { Margin = new Thickness(10, 10, 10, 10), MinWidth = 80, MinHeight = 30, Content = "Delete" });
                    ColorCol.Children.Add(info);
                }
            }
            _counter++;
        }


    }
}
