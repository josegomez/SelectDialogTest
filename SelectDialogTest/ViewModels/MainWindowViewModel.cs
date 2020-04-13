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
                OpenFileDialog dialog = null;// new OpenFileDialog();
                var file = await dialog.ShowAsync(this._mainWindow);
            }
            catch(Exception e)
            {
                Log.Error(e.StackTrace);
                Log.Error(e, "Error:");
            }
        }
    }
}
