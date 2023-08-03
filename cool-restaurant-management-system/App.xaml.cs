using cool_restaurant_management_system.Data;
using SQLite;

namespace cool_restaurant_management_system;

public partial class App : Application
{

    public App()
	{
		InitializeComponent();

		MainPage = new MainPage();

	}
}
