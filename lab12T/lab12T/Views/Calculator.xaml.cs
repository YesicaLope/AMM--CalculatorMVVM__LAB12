using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lab12T.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calculator : ContentPage
    {
        public Calculator()
        {
            InitializeComponent();
            this.BindingContext = new lab12T.ViewModels.CalculatorViewModel();  
        }

        internal static object Calculate(double firstNumber, double secondNumber, string mathOperator)
        {
            throw new NotImplementedException();
        }
    }
}