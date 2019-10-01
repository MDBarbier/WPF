using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DotNetCoreDemo.Models
{
    class Model1 : INotifyPropertyChanged
    {
        public string Name { get; set; } = "Matt";
        public bool _clickMeButtonEnabled = true;

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public bool ClickMeButtonEnabled
        {
            get => _clickMeButtonEnabled; set
            {
                if (_clickMeButtonEnabled != value)
                {
                    _clickMeButtonEnabled = value;
                    RaisePropertyChanged("GoButtonEnabled");

                }
            }
        }

    }
}
