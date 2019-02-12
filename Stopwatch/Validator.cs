using System;
using System.Globalization;
using System.Windows.Forms;

namespace Stopwatch
{
    public class Validator
    {
        public static bool IsPresent(TextBox txt, string name)
        {
            if (txt.Text == "")
            {
                MessageBox.Show(name + " is required field", "Entry Error");
                txt.Focus();
                return false;
            }
            return true;
        }

        public static bool IsNumber(TextBox txt, string name)
        {
            //this filters out anything other than numbers from the textbox
            char[] numbersArray = txt.Text.ToCharArray();
            string result = "";
            foreach (var item in numbersArray)
            {
                if (Char.IsNumber(item))
                    result += item;
            }

            //Int32 too short for 16digit number
            long number = 0;
            if (!Int64.TryParse(result, NumberStyles.Any, CultureInfo.CurrentCulture, out number))
            {
                MessageBox.Show(name + " must be a number", "Entry Error");
                txt.Focus();
                return false;
            }
            return true;
        }

        public static bool IsTime(TextBox txt, string name)
        {
            int number = Int32.Parse(txt.Text);
            if (number > 60)
            {
                MessageBox.Show(name + " must be a time format", "Entry Error");
                txt.Focus();
                return false;
            }
            return true;
        }

        public static bool IsInRange(TextBox txt, string name, int min, int max)
        {
            string number = "";
            foreach (var item in txt.Text)
            {
                if (Char.IsDigit(item))
                {
                    number += item;
                }
            }
            if (number.Length < 16 || number.Length > 16)
            {
                MessageBox.Show(name + " field must contain 16 integers");
                txt.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
