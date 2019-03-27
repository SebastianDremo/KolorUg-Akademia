using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinDemo.Annotations;

namespace XamarinDemo.ViewModel
{
    public class HelloViewModel : INotifyPropertyChanged
    {

        public ICommand ToggledCommand;

        private bool _isToggled;

        public bool IsToggled
        {
            get => _isToggled;
            set
            {
                _isToggled = value;
                OnPropertyChanged("IsToggled");
            }
        }
        public HelloViewModel()
        {
            ToggledCommand=new Command(ChangeBool);
        }

        public void ChangeBool()
        {
            IsToggled = !_isToggled;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
