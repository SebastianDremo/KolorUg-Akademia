using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CalculatorPage : ContentPage
	{
        public float Result { get; set; }
		public CalculatorPage ()
		{
			InitializeComponent ();
		}

        private void Button_OnClicked(object sender, EventArgs e)
        {
            var button = (Button) sender;

            switch (button.Text)
            {
                case "+":
                    Result = int.Parse(FirstNumber.Text) + int.Parse(SecondNumber.Text);
                    break;
                case "-":
                    Result = int.Parse(FirstNumber.Text) - int.Parse(SecondNumber.Text);
                    break;
                case "*":
                    Result = int.Parse(FirstNumber.Text) * int.Parse(SecondNumber.Text);
                    break;
                case "/":
                    Result = int.Parse(FirstNumber.Text) / int.Parse(SecondNumber.Text);
                    break;
            }

            ResultLabel.Text = Result.ToString();
        }
    }
}