using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinDemo.ViewModel;

namespace XamarinDemo.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HelloPage : ContentPage
    {
        private HelloViewModel vm;
        public HelloPage()
        {
            vm = new HelloViewModel();
            BindingContext = vm;
            InitializeComponent();
        }

        private void Switch_OnToggled(object sender, ToggledEventArgs e)
        {
            vm.ChangeBool();
        }
    }
}