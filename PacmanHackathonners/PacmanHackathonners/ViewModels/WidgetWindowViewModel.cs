using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using PacmanHackathonners.Commands;

namespace PacmanHackathonners.ViewModels
{
	public class WidgetWindowViewModel : ViewModelBase
	{
		private DelegateCommand startClick;
		public ICommand StartClick
		{
			get
			{
				return startClick = new DelegateCommand(delegate
				{
					foreach (Window window in Application.Current.Windows)
					{
						if (window is MainWindow)
						{
							window.Show();
						}
					}
				});
			}
		}
	}
}
