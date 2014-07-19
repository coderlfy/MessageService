using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Message.Model
{
    public class NotifyMessage
    {
        public const string _TagFormat = "_Notify._Message={0}";

        private string _message;

        public string _Message
        {
            get { return _message; }
            set { _message = value; }
        }
        
    }
}
