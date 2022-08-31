using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBiz.Validation
{
    public static class Validator
    {
        public static bool IsNumber(string input)
        {
            int tempID;
            if (Int32.TryParse(input, out tempID))            
                return true;           
            return false;
        }
    }
}
