using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using PacmanHackathonners.ViewModels;
using PacmanHackathonners.Views;

namespace PacmanHackathonners
{
	/// <summary>
	/// Логика взаимодействия для App.xaml
	/// </summary>
	public partial class App : Application
	{
		private void ApplicationStartup(object sender, StartupEventArgs e)
		{
			WidgetWindowViewModel widgetWindowViewModel = new WidgetWindowViewModel();
			WidgetWindow widgetWindow = new WidgetWindow(widgetWindowViewModel);
			widgetWindow.Show();

			MainWindowVIewModel mainWindowVIewModel = new MainWindowVIewModel();
			MainWindow mainWindow = new MainWindow(mainWindowVIewModel);
		}
	}
}
