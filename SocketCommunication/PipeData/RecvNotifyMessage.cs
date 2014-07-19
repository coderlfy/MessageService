using Message.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocketCommunication.PipeData
{
    public class RecvNotifyMessage : IClientCommand
    {
        private NotifyMessage _notify;

        public NotifyMessage _Notify
        {
            get { return _notify; }
            set { _notify = value; }
        }

        public override bool Analysis()
        {
            List<string> analysisinfor = base.Split(1);
            int viewlength = (analysisinfor[0].Length > PopwinModel._MaxContent)
                ? PopwinModel._MaxContent
                : analysisinfor[0].Length;

            if (analysisinfor != null)
            {
                base._PopwinModel = new PopwinModel()
                {
                    _Describe = analysisinfor[0].Substring(0, viewlength),
                    _Title = "您有新的通知了！",
                    _StyleIndex = 1,
                    _Tag = string.Format(NotifyMessage._TagFormat, analysisinfor[0])
                };
                
            }

            return true;
        }

        public override List<byte> GetCommand()
        {
            string content = string.Format("{0}", this._Notify._Message);

            List<byte> businesscommand = new List<byte>();
            businesscommand.Add((byte)TProtocol.RecvNotifyMessage);
            businesscommand.AddRange(UTF8Encoding.UTF8.GetBytes(content));
            return businesscommand;
        }


    }
}
