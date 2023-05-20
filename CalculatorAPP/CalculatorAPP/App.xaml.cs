using CalculatorAPP.MVVM.Views;

namespace CalculatorAPP;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage =  new NavigationPage(new CalculatorView());
    }
}
