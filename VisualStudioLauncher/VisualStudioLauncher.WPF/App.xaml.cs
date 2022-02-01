using Prism.Ioc;
using System.Windows;
using VisualStudioLauncher.WPF.Store;
using VisualStudioLauncher.WPF.Store.Interfaces;
using VisualStudioLauncher.WPF.Views;

namespace VisualStudioLauncher.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton(typeof(ISettingsStore), typeof(SettingsStore));
        }

        protected override Window CreateShell()
        {
           return Container.Resolve<MainWindow>();
        }
    }
}
