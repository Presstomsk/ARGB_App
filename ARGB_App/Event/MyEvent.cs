using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ARGB_App.Event
{
    public class MyEvent : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
