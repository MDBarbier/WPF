using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfViewModelLocator_Test.ViewModels
{
    public partial class ViewModelLocator
    {
        public ViewModel ViewModel
        {
            get
            {
                return new ViewModel("Hello ViewModel Locator!");
            }
        }
    }
}
