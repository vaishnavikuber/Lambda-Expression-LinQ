using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaAndLinQ
{
    internal class AgeInvalidException  : Exception
    {
        public string VMessage;
        
        public AgeInvalidException(string vmessage)
        {
            this.VMessage = vmessage;
        }
    }
}
