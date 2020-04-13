using System;
using System.Collections.Generic;
using System.Text;
using Avalonia;
using ReactiveUI;
using SelectDialogTest.Views;

namespace SelectDialogTest.ViewModels
{
    public class ViewModelBase : ReactiveObject
    {
        protected MainWindow _mainWindow = AvaloniaLocator.Current.GetService<MainWindow>();
    }
}
