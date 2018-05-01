using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RelativeLayoutTest.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public DelegateCommand TestCommand { get; set; }

        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            Title = "Main Page";
            TestCommand = new DelegateCommand(Test);
        }

        private void Test()
        {
            var test = "This is a test";
        }
    }
}
