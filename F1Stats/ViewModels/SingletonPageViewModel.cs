using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Stats.ViewModels
{
    public partial class SingletonPageViewModel : ObservableObject
    {
        private static readonly SingletonPageViewModel _instance = new SingletonPageViewModel();

        public static SingletonPageViewModel Instance
        {
            get { return _instance; }
        }

        [ObservableProperty]
        int count;

        [RelayCommand]
        void IncreaseCount() => Count++;
    }
}
