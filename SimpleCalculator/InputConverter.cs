using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class InputConverter
    {
        public double ConvertInputToNumeric(string textinput)
        {
            double convertedNumber;
            if (!double.TryParse(textinput, out convertedNumber))
            {
                throw new ArgumentException("Expected a numeric value.");
            }
            

            return convertedNumber;           
        } 
    }
}
