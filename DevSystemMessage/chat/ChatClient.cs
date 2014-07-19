using DevSystemMessage.icon;
using Message.Model;
//using DevIMDataLibrary;
using SocketCommunication.PipeData;
using SocketCommunication.TcpSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevSystemMessage.chat
{
    public class PopWinEventArgs : EventArgs
    {
        private PopwinModel _popwinmodel;

        public PopwinModel _PopWinModel
        {
            get { return _popwinmodel; }
            set { _popwinmodel = value; }
        }

    }
    class ChatClient
    {

        public event EventHandler OnConnected = null;
        public event EventHandler<PopWinEventArgs> OnPop = null;
        public static TcpClientEx ConnectServer()
        {
            #region
            TcpClientEx tcpclient = new TcpClientEx(
ServerInfor._Ip.ToString(), Convert.ToInt16(ServerInfor._Port));

            tcpclient.Connect();

            return tcpclient;
            #endregion
        }
        /// <summary>
        /// 
        /// </summary>
        public void RegisterListen()
        {
            #region

            TcpClientEx tcpclient = ChatClient.ConnectServer();

            if (OnConnected != null)
                this.OnConnected(null, null);

            sendRegisterToServer(tcpclient);
            //可接收是否发送成功
            while(true)
            {
                tcpclient.Receive();

                IClientCommand clientcommand = tcpclient.DispatcherAll();

                Console.WriteLine("来信息喽：{0}", 
                    clientcommand._PopwinModel._StyleIndex);

                if (OnPop != null)
                    OnPop(null, new PopWinEventArgs() 
                    { 
                        _PopWinModel = clientcommand._PopwinModel 
                    });
                /*
                string assemblypath = Path.Combine(
    AppDomain.CurrentDomain.BaseDirectory,
    "InsideMail.dll");

                Assembly assembly = Assembly.LoadFrom(assemblypath);

                Type t = assembly.GetType("InsideMail.FrmMailContent");

                ExtForm obj = (ExtForm)Activator.CreateInstance(t);

                obj._Tag = "_Mail._From=user12-_Mail._Content=什么";
                obj.ShowDialog();
                */
            }
            #endregion
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        private void sendRegisterToServer(TcpClientEx client)
        {
            #region
            SendRegisterClientListen sendregister = new 
                SendRegisterClientListen() { 
                _UserInfor = new DevIMDataLibrary.EntityTUser() { 
                    uid = "1" 
                } 
            };

            byte[] sendregistercommand = 
                sendregister.GetProtocolCommand();

            client.SendToEndDevice(sendregistercommand);

            #endregion
        }
    }
}
