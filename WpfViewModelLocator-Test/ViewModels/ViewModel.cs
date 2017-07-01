using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfViewModelLocator_Test.ViewModels
{
    public class ViewModel
    {
        public string Message { get; set; }

        public ViewModel(string message)
        {
            Message = message;
        }

        public ViewModel()
        {
            Message = "Hello ViewModel default constructor!";
        }
    }
}
