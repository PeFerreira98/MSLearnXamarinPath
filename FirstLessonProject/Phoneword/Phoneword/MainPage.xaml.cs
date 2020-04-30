using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Phoneword
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        protected string EnteredNumber;
        protected bool IsButtonEnabled;
        protected string ButtonTextCall;

        public MainPage()
        {
            EnteredNumber = "1-855-XAMARIN";
            IsButtonEnabled = false;
            ButtonTextCall = "Call";

            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var translatedNumber = PhonewordTranslator.ToNumber(EnteredNumber);
            if (!string.IsNullOrEmpty(translatedNumber))
            {
                IsButtonEnabled = true;
                ButtonTextCall = $"Call {translatedNumber}";
            }
            else
            {
                IsButtonEnabled = false;
                ButtonTextCall = "Call";
            }
        }
    }
}