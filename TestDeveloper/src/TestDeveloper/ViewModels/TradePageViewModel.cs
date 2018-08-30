using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Prism.Logging;
using Prism.Services;

namespace TestDeveloper.ViewModels
{
    public class TradePageViewModel : ViewModelBase
    {
        public TradePageViewModel(INavigationService navigationService, IPageDialogService pageDialogService, IDeviceService deviceService)
            : base(navigationService, pageDialogService, deviceService)
        {
            Title = "TradePage";
        }
    }
}
