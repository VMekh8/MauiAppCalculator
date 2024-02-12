
using System.Diagnostics;

namespace MauiAppCalculator
{
    public partial class MainPage : ContentPage
    {
        int CurrentState = 1;
        double number1, number2;
        string MathOperator;

        public MainPage()
        {
            InitializeComponent();
            OnClear(this, null);
        }
        

        private void OnClear(object sender, EventArgs e)
        {
            result.Text = "0";
            number1 = -1;
            number2 = -1;
            MathOperator = string.Empty;
            CurrentState = 1;
        }

        private void OnNumberInput(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string btnpress = button.Text;

            if (result.Text == "0" || CurrentState <0)
            {
                result.Text = string.Empty;
 
            }
            if(CurrentState % 2 == 0) 
                CurrentState *= -1;
            result.Text += btnpress;

            if (CurrentState == 1)
            {
                number1 = Convert.ToDouble(result.Text);
                Debug.WriteLine($"1-{number1} + {CurrentState}") ;
            }
            else
            {
                number2 = Convert.ToDouble(result.Text);
                Debug.WriteLine($"2-{number2} + {CurrentState}");
            }
        }

        private void OnMathOperSelect(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            CurrentState = -2;
            
            result.Text += button.Text;
            string btnpress = button.Text;
            MathOperator = btnpress;
        }

        private void OnCalc(object sender, EventArgs e)
        {
            if (number1 == -1 || number2 == -1)
            {
                result.Text = string.Empty;
                result.FontSize = 24;
                result.Text += "Не всі числа введенні";
            }
            else
            {
                double _result = Calculate.Calc(number1, number2, MathOperator);
                result.Text = string.Empty;
                result.Text += _result.ToString();
                number1 = _result;
            }
        }
       
        private void OnRootElem(object sender, EventArgs e)
        {
            if (number1 == 0)
            {
                return;
            }
            result.Text = (number1 * number1).ToString();
        }
    }

}
