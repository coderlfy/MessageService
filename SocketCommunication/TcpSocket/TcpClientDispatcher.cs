using SocketCommunication.PipeData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocketCommunication.TcpSocket
{
    class TcpClientDispatcher : TcpDispatcher
    {
        private IClientCommand _clientCommand;

        public IClientCommand _ClientCommand
        {
            get { return _clientCommand; }
            set { _clientCommand = value; }
        }
        
        public TcpClientDispatcher(IClientCommand socketcommand)
        {
            this._ClientCommand = socketcommand;
        }

        public TcpClientDispatcher()
        {
            
        }

        public override bool Run()
        {
            return _clientCommand.Analysis();
        }

        public void RunAll(List<byte> data)
        {
            _ClientCommand = ProtocolRule.GetClientCommand(data);
            _ClientCommand._AfterDecodeData = data;
            _ClientCommand._AfterDecodeData.RemoveAt(0);
            _ClientCommand._AfterDecodeData.RemoveAt(0);
            _ClientCommand._AfterDecodeData.RemoveAt(_ClientCommand._AfterDecodeData.Count - 1);
            _ClientCommand.Analysis();

        }
    }
}
