using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_App
{
    partial class KitchenViewModel : ObservableObject
    {
        [ObservableProperty]
        double brightness;
        [ObservableProperty]
        double lowerLeftBright;
        [ObservableProperty]
        double lowerRightBright;
        [ObservableProperty]
        Boolean isSync;

        [RelayCommand]
        void syncBinding()
        {
            if (IsSync)
            {

            }
        }           
    }
}
