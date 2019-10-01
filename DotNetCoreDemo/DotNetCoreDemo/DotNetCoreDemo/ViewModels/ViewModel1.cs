using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Input;
using DotNetCoreDemo.Code;
using DotNetCoreDemo.Models;

namespace DotNetCoreDemo.ViewModels
{
    class ViewModel1 : INotifyPropertyChanged
    {

        public Model1 Model1 { get; set; }

        public ViewModel1()
        {
            Model1 = new Model1();
            ClickMeCommand = new RelayCommand(ClickMeButtonExecuteMethod, ClickMeButtonCanExecuteMethod);
        }

        public ICommand ClickMeCommand { get; set; }

        private bool ClickMeButtonCanExecuteMethod(object parameter)
        {
            if (parameter != null && Model1.ClickMeButtonEnabled)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ClickMeButtonExecuteMethod(object parameter)
        {
            MessageBox.Show("Hello, world!");
        }

        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add
            {
                ((INotifyPropertyChanged)Model1).PropertyChanged += value;
            }

            remove
            {
                ((INotifyPropertyChanged)Model1).PropertyChanged -= value;
            }
        }
    }
}
