namespace MorseCoder
{
    public partial class MainPage : ContentPage
    {
        string morseCode = "";
        string message = "";

        string responseMorseCode = "";
        string responseMessage = "";
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnDotClicked(object sender, EventArgs e)
        {
            morseCode += ".";
            ((Label)TheCode).Text = morseCode;
        }

        private void OnDashClicked(object sender, EventArgs e)
        {
            morseCode += "-";
            ((Label)TheCode).Text = morseCode;
        }

        private void OnSpaceClicked(object sender, EventArgs e)
        {
            message += Morse.MorseCoder(morseCode);
            ((Label)TheText).Text = message;
            morseCode = "";
            ((Label)TheCode).Text = "";
        }

        private void ResponseDotClicked(object sender, EventArgs e)
        {
            responseMorseCode += ".";
            ((Label)ResponseCode).Text = responseMorseCode;
        }

        private void RresponseDashClicked(object sender, EventArgs e)
        {
            responseMorseCode += "-";
            ((Label)ResponseCode).Text = responseMorseCode;
        }

        private void ResponseSpaceClicked(object sender, EventArgs e)
        {
            responseMessage += Morse.MorseCoder(responseMorseCode);
            ((Label)ResponseText).Text = responseMessage;
            responseMorseCode = "";
            ((Label)ResponseCode).Text = "";
        }

        //private void OnCounterClicked(object sender, EventArgs e)
        // {
        //count++;

        // if (count == 1)
        //  CounterBtn.Text = $"Clicked {count} time";
        // else
        //  CounterBtn.Text = $"Clicked {count} times";

        //  SemanticScreenReader.Announce(CounterBtn.Text);
        // }
    }

}
