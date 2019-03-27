using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinDemo.ViewModel;

namespace XamarinDemo.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CalculatorPage : ContentPage
    {
        private CalculatorViewModel vmCalculatorViewModel;
		public CalculatorPage ()
		{
            vmCalculatorViewModel=new CalculatorViewModel();
            BindingContext = vmCalculatorViewModel;
            InitializeComponent();
        }
    }
}