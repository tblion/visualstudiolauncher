using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Prism;
using System.Threading.Tasks;
using Prism.Mvvm;
using VisualStudioLauncher.WPF.Model;

namespace VisualStudioLauncher.WPF.ViewModels
{
    public class SettingsViewModel : BindableBase
    {
        private ObservableCollection<Settings> _settingsList= null;

        public ObservableCollection<Settings> SettingsList
        {
            get => _settingsList;
            set => SetProperty<ObservableCollection<Settings>>(ref _settingsList, value);
        }

        public SettingsViewModel()
        {

        }
    }
}
