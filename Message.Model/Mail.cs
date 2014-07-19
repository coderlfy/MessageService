using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Message.Model
{
    public class Mail
    {
        public const string _TagFormat = "_Mail._From={0}-_Mail._Content={1}";
        private string _from;

        public string _From
        {
            get { return _from; }
            set { _from = value; }
        }

        private string _content;

        public string _Content
        {
            get { return _content; }
            set { _content = value; }
        }
        
    }
}
