using DevExpress.XtraEditors;
using SocketCommunication.Cache;
using SocketCommunication.PipeData;
using SocketCommunication.TcpSocket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerMessage
{
    public partial class FrmMain : XtraForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 发送到客户端消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbSendClient_Click(
            object sender, EventArgs e)
        {
            #region
            int messageindex = this.xtcMessageTab.SelectedTabPageIndex;

            Console.WriteLine(
                "this.xtcMessageTab.SelectedTabPageIndex={0}", 
                messageindex);

            byte[] cmd = (messageindex == 0) ? getNotifyCmd() : getMailCmd();

            Customer currentcustomer = this.lbcClientList.SelectedItem as Customer;

            Console.WriteLine("currentcustomer port:{0}", currentcustomer.Port);
            currentcustomer._SrcSocket.Send(cmd);
            #endregion
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private byte[] getNotifyCmd()
        {
            #region
            IClientCommand cmdobj = new RecvNotifyMessage()
            {
                _Notify = new Message.Model.NotifyMessage() { 
                    _Message = this.teNotifyMessage.Text
                }
            };

            return cmdobj.GetProtocolCommand();
            #endregion
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private byte[] getMailCmd()
        {
            #region
            IClientCommand cmdobj = new RecvMail()
            {
                _Mail = new Message.Model.Mail()
                {
                    _From = this.teMailFrom.Text,
                    _Content = this.teMailContent.Text
                }
            };
            return cmdobj.GetProtocolCommand();
            #endregion
        }
        /// <summary>
        /// 开启服务后的状态处理
        /// </summary>
        /// <param name="iar"></param>
        private void startedServer(IAsyncResult iar)
        {
            #region
            MethodInvoker dl_do = (MethodInvoker)iar.AsyncState;

            if (!this.InvokeRequired)
                return;
            dl_do.EndInvoke(iar);

            this.Invoke(new MethodInvoker(() => {
                this.lcMessageServerStatus.Text = "服务端状态：已开启";
            }));
            #endregion
        }
        /// <summary>
        /// 页面加载后的工作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(
            object sender, EventArgs e)
        {
            #region
            AsyncCallback callbak = new AsyncCallback(startedServer);
            MethodInvoker method = new MethodInvoker(StartMessageServer);
            method.BeginInvoke(callbak, method);
            #endregion
        }
        /// <summary>
        /// 开启服务端的消息服务
        /// </summary>
        private void StartMessageServer()
        {
            #region
            TcpServer tcpserver = new TcpServer();
            CustomerCollector.OnAddEventHandler += CustomerCollector_OnAddEventHandler;
            CustomerCollector.OnRemoveEventHandler += CustomerCollector_OnRemoveEventHandler;
            //tcpserver.OnError += new EventHandler<ErrorEventArgs>(socketErrorHandler);
            Console.WriteLine(TcpServer.GetServerIpString());
            tcpserver.StartListen(1005);
            #endregion
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerCollector_OnRemoveEventHandler(
            object sender, CustomEventArgs e)
        {
            #region
            if (!this.InvokeRequired)
                return;
            this.Invoke(new MethodInvoker(() =>
            {
                this.lbcClientList.Items.Remove(e._Customer);
            }));
            #endregion
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerCollector_OnAddEventHandler(
            object sender, CustomEventArgs e)
        {
            #region
            if (!this.InvokeRequired)
                return;
            this.Invoke(new MethodInvoker(() =>
            {
                this.lbcClientList.Items.Add(e._Customer);
            }));
            #endregion
        }
    }
}
