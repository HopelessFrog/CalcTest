namespace TEST.CalcPageClasses
{
    using System;
    using System.Collections.Generic;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using TEST.Extensions;

    public partial class CalcPage
    {
        private Dictionary<int, WinButton> _buttonsMap;

        private WinText _output;

        private WinButton _button1;
        private WinButton _button2;
        private WinButton _button3;
        private WinButton _button4;
        private WinButton _button5;
        private WinButton _button6;
        private WinButton _button7;
        private WinButton _button8;
        private WinButton _button9;
        private WinButton _button0;

        private WinButton _buttonDivide;
        private WinButton _buttonMultiply;
        private WinButton _buttonSubtract;
        private WinButton _buttonAdd;

        private WinButton _buttonClear;
        private WinButton _buttonEquals;

        public void SetControls()
        {
            _button1 = this.UICalculatorWindow.UIItem1.UI1Button;
            _button2 = this.UICalculatorWindow.UIItem2.UI2Button;
            _button3 = this.UICalculatorWindow.UIItem3.UI3Button;
            _button4 = this.UICalculatorWindow.UIItem4.UI4Button;
            _button5 = this.UICalculatorWindow.UIItem5.UI5Button;
            _button6 = this.UICalculatorWindow.UIItem6.UI6Button;
            _button7 = this.UICalculatorWindow.UIItem7.UI7Button;
            _button8 = this.UICalculatorWindow.UIItem8.UI8Button;
            _button9 = this.UICalculatorWindow.UIItem9.UI9Button;
            _button0 = this.UICalculatorWindow.UIItem0.UI0Button;
            _buttonAdd = this.UICalculatorWindow.UIItemAdd.UIAddButton;
            _buttonSubtract = this.UICalculatorWindow.UIItemSubtract.UISubtractButton;
            _buttonMultiply = this.UICalculatorWindow.UIItemMultiply.UIMultiplyButton;
            _buttonDivide = this.UICalculatorWindow.UIItemDivide.UIDivideButton;
            _buttonEquals = this.UICalculatorWindow.UIItemEquals.UIEqualsButton;
            _output = this.UICalculatorWindow.UIItemOutput.UIOutputText;
            _buttonClear = this.UICalculatorWindow.UIItemClear.UIClearButton;

            MapControls();
        }

        public string Add(int firstNum, int secondNum)
        {
            return DoMath(firstNum, secondNum, () => Mouse.Click(_buttonAdd, _buttonAdd.GetClickablePoint()));
        }

        public string Subtract(int firstNum, int secondNum)
        {
            return DoMath(firstNum, secondNum, () => Mouse.Click(_buttonSubtract, _buttonSubtract.GetClickablePoint()));
        }

        public string Multiply(int firstNum, int secondNum)
        {
            return DoMath(firstNum, secondNum, () => Mouse.Click(_buttonMultiply, _buttonMultiply.GetClickablePoint()));
        }

        public string Divide(int firstNum, int secondNum)
        {
            return DoMath(firstNum, secondNum, () => Mouse.Click(_buttonDivide, _buttonDivide.GetClickablePoint()));
        }

        public void Clear()
        {
            SetControls();

            Mouse.Click(_buttonClear, _buttonClear.GetClickablePoint());
        }

        private string DoMath(int firstNum, int secondNum, Action action)
        {
            SetControls();

            var firstDigits = firstNum.GetDigits();

            foreach (var digit in firstDigits)
            {
                if (!_buttonsMap.TryGetValue(digit, out var button))
                    throw new AggregateException("Not mapped digit presented");

                Mouse.Click(button, button.GetClickablePoint());
            }

            action();

            var secondDigits = secondNum.GetDigits();

            foreach (var digit in secondDigits)
            {
                if (!_buttonsMap.TryGetValue(digit, out var button))
                    throw new AggregateException("Not mapped digit presented");

                Mouse.Click(button, button.GetClickablePoint());
            }

            Mouse.Click(_buttonEquals, _buttonEquals.GetClickablePoint());

            return _output.DisplayText;
        }

        private void MapControls()
        {
            _buttonsMap = new Dictionary<int, WinButton>
            {
                { 0, _button0},
                { 1, _button1},
                { 2, _button2},
                { 3, _button3},
                { 4, _button4},
                { 5, _button5},
                { 6, _button6},
                { 7, _button7},
                { 8, _button8},
                { 9, _button9}
            };
        }
    }
}
