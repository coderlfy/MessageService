using DevExpress.XtraBars.Alerter;
using DevExpress.XtraEditors;
using DevSystemMessage.chat;
using Fundation.Core;
using Message.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using SystemInterface;

namespace DevSystemMessage
{
    public partial class FrmMain : XtraForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbConnectServer_Click(
            object sender, EventArgs e)
        {
            #region
            object serverip, serverport;

            serverip = this.teServerIP.Text;
            serverport = this.teServerPort.Text;

            Config.Update(ServerInfor.KeyNameServerIP, ref serverip);
            Config.Update(ServerInfor.KeyNameServerPort, ref serverport);

            ServerInfor._Ip = serverip;
            ServerInfor._Port = Convert.ToInt16(serverport);


            MethodInvoker gd = new MethodInvoker(() =>
            {
                ChatClient chatclient = new ChatClient();
                chatclient.OnConnected += chatclient_OnConnected;
                chatclient.OnPop += chatclient_OnPop;
                chatclient.RegisterListen();
                
            });
            gd.BeginInvoke(null, null);
            #endregion
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chatclient_OnPop(
            object sender, PopWinEventArgs e)
        {
            #region
            if (!this.InvokeRequired)
                return;
            this.Invoke(new MethodInvoker(() =>
            {
                AlertControl control = new AlertControl();
                
                control.Show(this.FindForm(), 
                    e._PopWinModel._Title, 
                    e._PopWinModel._Describe, 
                    null, 
                    null, 
                    e._PopWinModel);

                control.AlertClick += control_AlertClick;
            }));
            #endregion
        }

        private void control_AlertClick(
            object sender, AlertClickEventArgs e)
        {
            dispatcherPop(e.Info.Tag as PopwinModel);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chatclient_OnConnected(
            object sender, EventArgs e)
        {
            #region
            if (!this.InvokeRequired)
                return;
            this.Invoke(new MethodInvoker(() =>
            {
                this.sbConnectServer.Enabled = false;
                this.teServerPort.Enabled = false;
                this.teServerIP.Enabled = false;
            }));
            #endregion
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(
            object sender, EventArgs e)
        {
            #region
            this.teServerIP.Text = ServerInfor._Ip.ToString();
            this.teServerPort.Text = ServerInfor._Port.ToString();
            //初始化消息类型配置
            MessageConfigs.Init();
            #endregion
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="popobj"></param>
        private void dispatcherPop(
            PopwinModel popobj)
        {
            #region
            MessageConfig msgconfig = MessageConfigs
                .FindByIndex(popobj._StyleIndex);

            if (msgconfig != null)
            {
                string assemblypath = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    msgconfig._DllName);

                Assembly assembly = Assembly.LoadFrom(assemblypath);

                Type t = assembly.GetType(msgconfig._ClassName);

                ExtForm obj = (ExtForm)Activator.CreateInstance(t);

                obj._Tag = popobj._Tag;
                obj.ShowDialog();
            }
            #endregion
        }
    }
}
