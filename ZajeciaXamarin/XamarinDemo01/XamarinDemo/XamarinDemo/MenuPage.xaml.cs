using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinDemo.View;

namespace XamarinDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : Xamarin.Forms.TabbedPage
    {
        public MenuPage ()
        {
            InitializeComponent();
        }

        public MenuPage(View.CalculatorPage calculatorPage, BMICalc bmiCalc, HelloPage hello)
        {
            Children.Add(calculatorPage);
            Children.Add(bmiCalc);
            Children.Add(hello);
        }

        public MenuPage(View.CalculatorPage calculatorPage, BMICalc bmiCalc, View.CalculatorPage calculatorPage1)
        {
            throw new System.NotImplementedException();
        }
    }
}