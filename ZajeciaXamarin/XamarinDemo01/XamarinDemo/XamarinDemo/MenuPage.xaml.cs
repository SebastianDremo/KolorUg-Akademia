using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : Xamarin.Forms.TabbedPage
    {
        public MenuPage ()
        {
            InitializeComponent();
        }

        public MenuPage(CalculatorPage calculatorPage, BMICalc bmiCalc)
        {
            Children.Add(calculatorPage);
            Children.Add(bmiCalc);
        }
    }
}