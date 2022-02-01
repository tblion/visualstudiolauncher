using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Win32;
using Prism.Commands;
using Prism.Mvvm;

namespace VisualStudioLauncher.WPF.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title;

        public string Title
        {
            get => _title;
            set => SetProperty<string>(ref _title, value);
        }

        public DelegateCommand LaunchCommand { get; set; }

        public MainWindowViewModel()
        {
            this.Title = "Visual Studio Launcher";
            // Get Settings
          
            LaunchCommand = new DelegateCommand(LaunchCommand_Action);
        }

        private void LaunchCommand_Action()
        {

        }

        private async void GetData()
        {

        }
     
    }
}
