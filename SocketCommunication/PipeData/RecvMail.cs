using Message.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocketCommunication.PipeData
{
    public class RecvMail : IClientCommand
    {
        private Mail _mail;

        public Mail _Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

        public override bool Analysis()
        {
            List<string> analysisinfor = base.Split(2);

            int viewlength = (analysisinfor[1].Length > PopwinModel._MaxContent) 
                ? PopwinModel._MaxContent 
                : analysisinfor[1].Length;

            if (analysisinfor != null)
            {
                base._PopwinModel = new PopwinModel()
                {
                    _Describe = analysisinfor[1].Substring(0, viewlength),
                    _Title = "您有新的邮件了！",
                    _StyleIndex = 2,
                    _Tag = string.Format(Mail._TagFormat, analysisinfor[0], analysisinfor[1])
                };
                
            }

            return true;
        }

        public override List<byte> GetCommand()
        {
            string content = string.Format("{0};{1}", 
                this._Mail._From, 
                this._Mail._Content);

            List<byte> businesscommand = new List<byte>();
            businesscommand.Add((byte)TProtocol.RecvMail);
            businesscommand.AddRange(UTF8Encoding.UTF8.GetBytes(content));
            return businesscommand;
        }
    }
}
