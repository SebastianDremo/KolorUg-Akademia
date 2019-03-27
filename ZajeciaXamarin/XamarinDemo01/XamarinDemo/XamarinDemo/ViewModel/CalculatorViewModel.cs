using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinDemo.Annotations;
using XamarinDemo.Enum;


namespace XamarinDemo.ViewModel
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        public float _firstNumber;

        public float FirstNumber
        {
            get => _firstNumber;
            set
            {
                _firstNumber = value;
                OnPropertyChanged("FirstNumber");
            }
        }

        public float SecondNumber { get; set; }

        public float _result;

        public float Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged("Result");
            }
        }

        public MathematicalSigns SelectedMathematicalSign { get; set; }

        public ICommand SaveCommand { get; set; }


        private List<MathematicalSigns> _mathematicalSigns = new List<MathematicalSigns>()
        {
            Enum.MathematicalSigns.Plus,
            Enum.MathematicalSigns.Minus,
            Enum.MathematicalSigns.Multiplication,
            Enum.MathematicalSigns.Division
        };
        public List<MathematicalSigns> MathematicalSigns => _mathematicalSigns;

        public CalculatorViewModel()
        {
            SaveCommand = new Command(CalculateResult);
        }

        public void CalculateResult()
        {
            switch (SelectedMathematicalSign)
            {
                case Enum.MathematicalSigns.Plus:
                    Result = FirstNumber + SecondNumber;
                    FirstNumber = 0;
                    SecondNumber = 0;// to pole zrefreshuje na widoku bo nie jest uzywany interfejs
                    break;
                case Enum.MathematicalSigns.Minus:
                    Result = FirstNumber - SecondNumber;
                    break;
                case Enum.MathematicalSigns.Multiplication:
                    Result = FirstNumber * SecondNumber;
                    break;
                case Enum.MathematicalSigns.Division:
                    Result = FirstNumber / SecondNumber;
                    break;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
