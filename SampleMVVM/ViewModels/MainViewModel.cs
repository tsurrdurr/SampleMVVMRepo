using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMVVM
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {

        }

        public string Test
        {
            get => "test";
            set
            {
                OnPropertyChanged(nameof(Test));
            }
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);

        }
        #endregion
    }
}
