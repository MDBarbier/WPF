using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfMVVMDemo.Views
{
    /// <summary>
    /// Interaction logic for PersonViewer.xaml
    /// </summary>
    public partial class PersonViewer : UserControl
    {
        public PersonViewer()
        {
            InitializeComponent();

            //Alternative way to assign the viewmodel to the view - XAML method can only use default constructor 
            //so if you have multiple constructors would want to assign from here
            //this.DataContext = new WpfMVVMDemo.ViewModel.PersonViewModel();
        }
    }
}
