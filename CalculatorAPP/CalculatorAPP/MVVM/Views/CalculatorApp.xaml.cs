

using CalculatorAPP.ViewModels;

namespace CalculatorAPP.MVVM.Views
{
    public partial class CalculatorView : ContentPage
    {
        public CalculatorView()
        {
            InitializeComponent();
            BindingContext = new CalculatorViewModel();
        }
    }
}