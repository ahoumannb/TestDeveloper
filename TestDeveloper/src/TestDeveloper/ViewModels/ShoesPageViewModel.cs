using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Prism.Logging;
using Prism.Services;
using TestDeveloper.Views;

namespace TestDeveloper.ViewModels
{
    public class ShoesPageViewModel : ViewModelBase
    {
        public ShoesPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService, IDeviceService deviceService)
            : base(navigationService, pageDialogService, deviceService)
        {
            Title = "ShoesPage";
        }
    }
}
