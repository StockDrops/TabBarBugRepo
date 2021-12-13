using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using TabBarBugRepo.Pages;
using Application = Microsoft.Maui.Controls.Application;

namespace TabBarBugRepo
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new MobileShell();
			Routing.RegisterRoute(nameof(Page1), typeof(Page1));
			Routing.RegisterRoute(nameof(Page2), typeof(Page2));
			Routing.RegisterRoute(nameof(Page3), typeof(Page3));
		}
	}
}
