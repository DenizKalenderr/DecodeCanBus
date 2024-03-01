using System.ComponentModel;

namespace Imecar.LV_BMS.V2.Can_Bus_Interface.Common
{
    public class Common : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
