using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP2.Classes
{
    class DataValidation
    {
        bool _validString = false;
        bool _validInt = false;
        bool _validDouble = false;

        public DataValidation()
        {
        }

        public bool ValidateString(string stringToValidate)
        {
            _validString = true;
            return _validString; 
        }

        public bool ValidateInteger(string intToValidate)
        {
            int x = 0;
            if(Int32.TryParse(intToValidate, out x))
            {
                _validInt = true;
            }
            return _validInt;
        }

        public bool ValidateDouble(string doubleToValidate)
        {
            return _validDouble;
        }

    }
}
