using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Message.Model
{
    public class MessageConfigs
    {
        public static List<MessageConfig> _MessageConfigs = null;

        public static void Init()
        {
            if (_MessageConfigs == null)
            {
                _MessageConfigs = new List<MessageConfig>();
                _MessageConfigs.Add(new MessageConfig()
                {
                    _DllName = "InsideMail.dll",
                    _ClassName = "InsideMail.FrmMailContent",
                    _Discribe = "邮件",
                    _Index = 2,
                    _TagFormat = Mail._TagFormat
                });
                _MessageConfigs.Add(new MessageConfig()
                {
                    _DllName = "NotifyManage.dll",
                    _ClassName = "NotifyManage.FrmNotityMessage",
                    _Discribe = "通知公告",
                    _Index = 1,
                    _TagFormat = NotifyMessage._TagFormat
                });
            }
        }
        public static MessageConfig FindByIndex(int index)
        {
            MessageConfig msgconfig = null;
            foreach (MessageConfig temp in _MessageConfigs)
                if (temp._Index == index)
                {
                    msgconfig = temp;
                    break;
                }
            return msgconfig;
        }
    }
}
