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
        [ObservableProperty]
        string mainText;

        public KitchenViewModel() { MainText = "Upper Brightness Level:"; }
        [RelayCommand]
        void SyncBinding()
        {
            if (IsSync) { MainText = "Brightness Level:"; }
            else { MainText = "Upper Brightness Level:"; }
                UpdateBrightness();

        }
        [RelayCommand]
        void UpdateBrightness()
        {
            if (IsSync)
            {
                LowerLeftBright = Brightness; LowerRightBright = Brightness;

            }
        }
        [RelayCommand]
        void UpdateLeftBrightness()
        {
            if (IsSync)
            {
                Brightness = LowerLeftBright; LowerRightBright = LowerLeftBright;
            }
        }
        [RelayCommand]
        void UpdateRightBrightness()
        {
            if (IsSync)
            {
                Brightness = LowerRightBright; LowerLeftBright = LowerRightBright;
            }
        }
    }
}
