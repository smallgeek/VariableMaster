using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace VariableMaster.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private int _maximumFraction;
        public int MaximumFraction
        {
            get { return _maximumFraction; }
            set { SetProperty(ref _maximumFraction, value); }
        }

        private int _minimumFraction;
        public int MinimumFraction
        {
            get { return _minimumFraction; }
            set { SetProperty(ref _minimumFraction, value); }
        }

        private int _masterFraction;
        public int MasterFraction
        {
            get { return _masterFraction; }
            set 
            { 
                SetProperty(ref _masterFraction, value); 
            }
        }

        public MainPageViewModel()
        {
            this.MaximumFraction = 50;
            this.MinimumFraction = 0;
            this.MasterFraction = 30;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }
    }
}


