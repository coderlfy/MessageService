namespace DevSystemMessage
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.teServerIP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.teServerPort = new DevExpress.XtraEditors.TextEdit();
            this.sbConnectServer = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teServerIP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teServerPort.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 52);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(620, 299);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(42, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 14);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "服务器IP地址：";
            // 
            // teServerIP
            // 
            this.teServerIP.Location = new System.Drawing.Point(131, 13);
            this.teServerIP.Name = "teServerIP";
            this.teServerIP.Size = new System.Drawing.Size(141, 21);
            this.teServerIP.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(290, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "端口：";
            // 
            // teServerPort
            // 
            this.teServerPort.Location = new System.Drawing.Point(332, 13);
            this.teServerPort.Name = "teServerPort";
            this.teServerPort.Size = new System.Drawing.Size(68, 21);
            this.teServerPort.TabIndex = 6;
            // 
            // sbConnectServer
            // 
            this.sbConnectServer.Location = new System.Drawing.Point(406, 11);
            this.sbConnectServer.Name = "sbConnectServer";
            this.sbConnectServer.Size = new System.Drawing.Size(98, 23);
            this.sbConnectServer.TabIndex = 7;
            this.sbConnectServer.Text = "连接服务器";
            this.sbConnectServer.Click += new System.EventHandler(this.sbConnectServer_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 351);
            this.Controls.Add(this.sbConnectServer);
            this.Controls.Add(this.teServerPort);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.teServerIP);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统消息测试程序（客户端）";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teServerIP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teServerPort.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit teServerIP;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit teServerPort;
        private DevExpress.XtraEditors.SimpleButton sbConnectServer;
    }
}

