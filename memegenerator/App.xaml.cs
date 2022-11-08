using memegenerator.Services;

namespace memegenerator;

public partial class App : Application
{
	public App()
	{
        InitializeComponent();

        DependencyService.Register<WebClientService>();
		DependencyService.Register<MemeGeneratorDataStore>();

		MainPage = new AppShell();
	}
}
