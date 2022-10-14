namespace _07_EjerciciosPage;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new Views.PaginaTabbed();
	}
}
