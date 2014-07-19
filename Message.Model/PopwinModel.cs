using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Message.Model
{
    public class PopwinModel
    {
        public static int _MaxContent = 20;
        private int _styleindex;

        public int _StyleIndex
        {
            get { return _styleindex; }
            set { _styleindex = value; }
        }

        private string _title;

        public string _Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _describe;

        public string _Describe
        {
            get { return _describe; }
            set { _describe = value; }
        }

        private string _tag;

        public string _Tag
        {
            get { return _tag; }
            set { _tag = value; }
        }
        
    }
}
