using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Message.Model
{
    public class MessageConfig
    {
        private int _index;

        public int _Index
        {
            get { return _index; }
            set { _index = value; }
        }

        private string _discribe;

        public string _Discribe
        {
            get { return _discribe; }
            set { _discribe = value; }
        }

        private string _tagFormat;

        public string _TagFormat
        {
            get { return _tagFormat; }
            set { _tagFormat = value; }
        }
        private string _dllName;

        public string _DllName
        {
            get { return _dllName; }
            set { _dllName = value; }
        }
        
        private string _className;

        public string _ClassName
        {
            get { return _className; }
            set { _className = value; }
        }
        
    }
}
