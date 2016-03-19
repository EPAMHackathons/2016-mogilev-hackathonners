using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using PacmanHackathonners.ViewModels;

namespace PacmanHackathonners.Views
{
	/// <summary>
	/// Логика взаимодействия для WidgetWindow.xaml
	/// </summary>
	public partial class WidgetWindow : Window
	{
		public WidgetWindow(WidgetWindowViewModel widgetWindowViewModel)
		{
			InitializeComponent();
			DataContext = widgetWindowViewModel;
		}
	}
}
