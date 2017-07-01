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

namespace WPF_Binding_example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void updateSource_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression beX = xValue.GetBindingExpression(TextBox.TextProperty);
            beX.UpdateSource();

            BindingExpression beY = yValue.GetBindingExpression(TextBox.TextProperty);
            beY.UpdateSource();
        }
    }
}
