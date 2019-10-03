using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace DotNetCoreDemo.Models
{
    class Model1 : INotifyPropertyChanged
    {
        public string Name { get; set; } = "Matt";
        public bool _clickMeButtonEnabled = true;
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<string> _dateTimes;

        public Model1()
        {
            _dateTimes = new ObservableCollection<string>();
        }

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

        public ObservableCollection<string> DateTimes
        {
            get => _dateTimes; set
            {
                if (_dateTimes != value)
                {
                    _dateTimes = value;
                    RaisePropertyChanged("DateTimes");
                }
            }
        }
    }
}
