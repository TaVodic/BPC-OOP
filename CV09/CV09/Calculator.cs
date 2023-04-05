using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV09
{
    internal class Calculator
    {
        public string Display { get; private set; }
        public string Memory { get; private set; } 

        private enum State
        {
            FirstNum,
            Oparation,
            SecondNum,
            Result
        };

        private State _state;
        private double Result;
        private string _operator;
        private double FirstNum;
        private double SecondNum;

        public Calculator()
        {
            _state = State.FirstNum;
        }

        public void Button(string btnValue)
        {
            if(btnValue == "CE")
            {
                Display = "";
                Memory = "";
                FirstNum = 0;
                SecondNum = 0;
                _state = State.FirstNum;
                return;
            }

            if (btnValue == "C")
            {
                Display = Display.Remove(Display.Length - 1);
                return;
            }

            switch (_state)
            {
                case State.FirstNum:
                    if (int.TryParse(btnValue, out _) || btnValue == ",")
                    {                        
                        Display = Display + btnValue;
                    }
                    else
                    {                           
                        _operator = btnValue;
                        FirstNum = Convert.ToDouble(Display);                        
                        _state = State.SecondNum;
                        Memory = Display + " " + btnValue;
                        Display = "";
                    }
                    break;
                case State.SecondNum:
                    if (int.TryParse(btnValue, out _) || btnValue == ",")
                    {
                        Display = Display + btnValue;
                    }
                    else if(btnValue == "=")
                    {
                        SecondNum = Convert.ToDouble(Display);
                        Memory += " " + SecondNum;
                        var result = Calculate(FirstNum, SecondNum, _operator);
                        Display = Convert.ToString(result);
                        FirstNum = result;
                        _state = State.FirstNum;
                    }
                    break;
                default:
                    break;
            }
        }

        private double Calculate(double firstNum, double secondNum, string _operator)
        {
            switch (_operator)
            {
                case "+":
                    return firstNum + secondNum;
                case "-":
                    return firstNum - secondNum;
                case "*":
                    return firstNum * secondNum;
                case "/":
                    return firstNum / secondNum;
                default:
                    return 0;
            }
        }
    }
}
