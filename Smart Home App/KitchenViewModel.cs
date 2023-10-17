using CommunityToolkit.Mvvm.ComponentModel;
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

    }
}
