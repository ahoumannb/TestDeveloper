using System.Threading.Tasks;
using TestDeveloper.Views;
using Prism;
using Prism.Ioc;
using Autofac;
using Prism.Autofac;
using Prism.Logging;
using Xamarin.Forms;
using TestDeveloper.ViewModels;

namespace TestDeveloper
{
    public partial class App : PrismApplication
    {
        /* 
         * NOTE: 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App()
            : this(null)
        {
        }

        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            //await NavigationService.NavigateAsync("NavigationPage/MainPage");
            await NavigationService.NavigateAsync("TabbedPage?createTab=ShoesPage&createTab=TradePage&createTab=YouPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<TabbedPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<ShoesPage, ShoesPageViewModel>();
            containerRegistry.RegisterForNavigation<TradePage, TradePageViewModel>();
            containerRegistry.RegisterForNavigation<YouPage, YouPageViewModel>();

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle IApplicationLifecycle
            base.OnSleep();

            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle IApplicationLifecycle
            base.OnResume();

            // Handle when your app resumes
        }
    }
}
