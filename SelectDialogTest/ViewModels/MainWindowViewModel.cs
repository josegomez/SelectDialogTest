using Avalonia.Controls;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelectDialogTest.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";

        public async void CommandOpen()
        {
            try
            {
                Log.Information("Button Click");
                OpenFileDialog dialog = new OpenFileDialog();
                var file = await dialog.ShowAsync(this._mainWindow);
                Log.Information("All Good");
            }
            catch(Exception e)
            {
                Log.Error(e.StackTrace);
                Log.Error(e, "Error:");
            }
        }
    }
}
