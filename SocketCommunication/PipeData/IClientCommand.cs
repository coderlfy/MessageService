using Message.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocketCommunication.PipeData
{
    public abstract class IClientCommand : ISocketCommand
    {
        private PopwinModel _popwinModel;

        public PopwinModel _PopwinModel
        {
            get { return _popwinModel; }
            set { _popwinModel = value; }
        }
        
        //public abstract void Analysis();

        //public abstract List<byte> GetCommand();
    }
}
