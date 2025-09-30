using gatya.Model;
using gatya.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace gatya
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private gatyaModel _model;
        private gatyaViewModel _viewModel;
        private MainWindow _mainWindow;
        public App() 
        {
            Startup += App_StartUp;    
        }

        private void App_StartUp(object sender, StartupEventArgs e)
        {
            _model = new gatyaModel();
            _mainWindow = new MainWindow();
            _viewModel = new gatyaViewModel(_model);
            _mainWindow.DataContext = _viewModel;
            MainWindow.Show();
        }
    }
}
