using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GeneralUtilities
{
    public static class clsHelper
    {
        public static bool AreAnyTextBoxesEmpty(params TextBox[] textBoxes)
        {
            foreach (var tb in textBoxes)
            {
                if (tb.Visible && string.IsNullOrWhiteSpace(tb.Text))
                    return true;
            }
            return false;
        }
        public static bool ValidateEmail(TextBox textBox, ErrorProvider errorProvider, CancelEventArgs e)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(textBox.Text, pattern))
            {
                e.Cancel = true;
                textBox.Focus();
                errorProvider.SetError(textBox, "Please enter a valid email!");
                return false;
            }
            else
            {
                errorProvider.SetError(textBox, "");
                return true;
            }
        }
        public static void InputLettersOnly(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        public static void InputNumbersOnly(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
        public static void Decimalnumbers(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' ||
                         (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."));
        }
        public static void SetBorderSize(params Button[] buttons)
        {
            foreach (var button in buttons)
            {
                button.MouseHover += (sender, e) =>
                {
                    if (sender is Button btn)
                    {
                        btn.FlatAppearance.BorderSize = 1;
                    }
                };

                button.MouseLeave += (sender, e) =>
                {
                    if (sender is Button btn)
                    {
                        btn.FlatAppearance.BorderSize = 0;
                    }
                };
            }
        }
        public static void SetVisibility(bool visible, params Control[] controls)
        {
            foreach (var control in controls)
            {
                control.Visible = visible;
            }
        }
        public static void ClearTextBoxes(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.Clear();
            }
        }
        public static void SetTextBoxState(bool enabled, params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.Enabled = enabled;
            }
        }

        public static void SetControlsState(bool enabled, params Control[] controls)
        {
            foreach (var control in controls)
            {
                control.Enabled = enabled;
            }
        }
        public static void SetControlsState(bool enabled, GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is TextBox || control is ComboBox || control is CheckBox || control is RadioButton || control is Button)
                {
                    control.Enabled = enabled;
                }
            }
        }

        public static void ClearGroupBoxSelections(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
                else if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }
        }

    }
    public static class clsString
    { 
    
    public static string NumberToText(int number)
        {
            if (number == 0)
                return "";

            if (number >= 1 && number <= 19)
            {
                string[] arr = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven",
                         "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen",
                         "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

                return arr[number] + " ";
            }

            if (number >= 20 && number <= 99)
            {
                string[] arr = { "", "", "Twenty", "Thirty", "Forty", "Fifty",
                         "Sixty", "Seventy", "Eighty", "Ninety" };

                return arr[number / 10] + " " + NumberToText(number % 10);
            }

            if (number >= 100 && number <= 199)
            {
                return "One Hundred " + NumberToText(number % 100);
            }

            if (number >= 200 && number <= 999)
            {
                return NumberToText(number / 100) + "Hundreds " + NumberToText(number % 100);
            }

            if (number >= 1000 && number <= 1999)
            {
                return "One Thousand " + NumberToText(number % 1000);
            }

            if (number >= 2000 && number <= 999999)
            {
                return NumberToText(number / 1000) + "Thousands " + NumberToText(number % 1000);
            }

            if (number >= 1000000 && number <= 1999999)
            {
                return "One Million " + NumberToText(number % 1000000);
            }

            if (number >= 2000000 && number <= 999999999)
            {
                return NumberToText(number / 1000000) + "Millions " + NumberToText(number % 1000000);
            }

            if (number >= 1000000000 && number <= 1999999999)
            {
                return "One Billion " + NumberToText(number % 1000000000);
            }

            return NumberToText(number / 1000000000) + "Billions " + NumberToText(number % 1000000000);
        }

    }
}
