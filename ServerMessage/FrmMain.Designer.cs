namespace ServerMessage
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.xtcMessageTab = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.lcNotityMessage = new DevExpress.XtraEditors.LabelControl();
            this.teNotifyMessage = new DevExpress.XtraEditors.MemoEdit();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.lcMailContent = new DevExpress.XtraEditors.LabelControl();
            this.teMailFrom = new DevExpress.XtraEditors.TextEdit();
            this.lcMailFrom = new DevExpress.XtraEditors.LabelControl();
            this.teMailContent = new DevExpress.XtraEditors.MemoEdit();
            this.sbSendClient = new DevExpress.XtraEditors.SimpleButton();
            this.lcMessageServerStatus = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lbcClientList = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtcMessageTab)).BeginInit();
            this.xtcMessageTab.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teNotifyMessage.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teMailFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMailContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbcClientList)).BeginInit();
            this.SuspendLayout();
            // 
            // xtcMessageTab
            // 
            this.xtcMessageTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtcMessageTab.Location = new System.Drawing.Point(2, 23);
            this.xtcMessageTab.Name = "xtcMessageTab";
            this.xtcMessageTab.SelectedTabPage = this.xtraTabPage1;
            this.xtcMessageTab.Size = new System.Drawing.Size(457, 215);
            this.xtcMessageTab.TabIndex = 0;
            this.xtcMessageTab.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.lcNotityMessage);
            this.xtraTabPage1.Controls.Add(this.teNotifyMessage);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(451, 187);
            this.xtraTabPage1.Text = "通知公告";
            // 
            // lcNotityMessage
            // 
            this.lcNotityMessage.Location = new System.Drawing.Point(28, 38);
            this.lcNotityMessage.Name = "lcNotityMessage";
            this.lcNotityMessage.Size = new System.Drawing.Size(84, 14);
            this.lcNotityMessage.TabIndex = 1;
            this.lcNotityMessage.Text = "通知公告内容：";
            // 
            // teNotifyMessage
            // 
            this.teNotifyMessage.Location = new System.Drawing.Point(131, 35);
            this.teNotifyMessage.Name = "teNotifyMessage";
            this.teNotifyMessage.Size = new System.Drawing.Size(287, 126);
            this.teNotifyMessage.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.lcMailContent);
            this.xtraTabPage2.Controls.Add(this.teMailFrom);
            this.xtraTabPage2.Controls.Add(this.lcMailFrom);
            this.xtraTabPage2.Controls.Add(this.teMailContent);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(451, 187);
            this.xtraTabPage2.Text = "内部邮箱";
            // 
            // lcMailContent
            // 
            this.lcMailContent.Location = new System.Drawing.Point(35, 76);
            this.lcMailContent.Name = "lcMailContent";
            this.lcMailContent.Size = new System.Drawing.Size(60, 14);
            this.lcMailContent.TabIndex = 2;
            this.lcMailContent.Text = "邮箱内容：";
            // 
            // teMailFrom
            // 
            this.teMailFrom.Location = new System.Drawing.Point(112, 40);
            this.teMailFrom.Name = "teMailFrom";
            this.teMailFrom.Size = new System.Drawing.Size(315, 21);
            this.teMailFrom.TabIndex = 1;
            // 
            // lcMailFrom
            // 
            this.lcMailFrom.Location = new System.Drawing.Point(35, 43);
            this.lcMailFrom.Name = "lcMailFrom";
            this.lcMailFrom.Size = new System.Drawing.Size(60, 14);
            this.lcMailFrom.TabIndex = 0;
            this.lcMailFrom.Text = "邮箱来源：";
            // 
            // teMailContent
            // 
            this.teMailContent.Location = new System.Drawing.Point(112, 72);
            this.teMailContent.Name = "teMailContent";
            this.teMailContent.Size = new System.Drawing.Size(315, 92);
            this.teMailContent.TabIndex = 3;
            // 
            // sbSendClient
            // 
            this.sbSendClient.Location = new System.Drawing.Point(300, 354);
            this.sbSendClient.Name = "sbSendClient";
            this.sbSendClient.Size = new System.Drawing.Size(149, 27);
            this.sbSendClient.TabIndex = 1;
            this.sbSendClient.Text = "发送到客户端";
            this.sbSendClient.Click += new System.EventHandler(this.sbSendClient_Click);
            // 
            // lcMessageServerStatus
            // 
            this.lcMessageServerStatus.Location = new System.Drawing.Point(12, 362);
            this.lcMessageServerStatus.Name = "lcMessageServerStatus";
            this.lcMessageServerStatus.Size = new System.Drawing.Size(108, 14);
            this.lcMessageServerStatus.TabIndex = 2;
            this.lcMessageServerStatus.Text = "服务端状态：未开启";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.xtcMessageTab);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 95);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(461, 240);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "发送信息类型及内容";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lbcClientList);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(461, 95);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "在线客户端列表";
            // 
            // lbcClientList
            // 
            this.lbcClientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbcClientList.Location = new System.Drawing.Point(2, 23);
            this.lbcClientList.Name = "lbcClientList";
            this.lbcClientList.Size = new System.Drawing.Size(457, 70);
            this.lbcClientList.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 384);
            this.Controls.Add(this.lcMessageServerStatus);
            this.Controls.Add(this.sbSendClient);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统消息测试程序（服务端）";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtcMessageTab)).EndInit();
            this.xtcMessageTab.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teNotifyMessage.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teMailFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMailContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbcClientList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtcMessageTab;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.LabelControl lcNotityMessage;
        private DevExpress.XtraEditors.LabelControl lcMailContent;
        private DevExpress.XtraEditors.TextEdit teMailFrom;
        private DevExpress.XtraEditors.LabelControl lcMailFrom;
        private DevExpress.XtraEditors.MemoEdit teMailContent;
        private DevExpress.XtraEditors.SimpleButton sbSendClient;
        private DevExpress.XtraEditors.MemoEdit teNotifyMessage;
        private DevExpress.XtraEditors.LabelControl lcMessageServerStatus;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.ListBoxControl lbcClientList;
    }
}

