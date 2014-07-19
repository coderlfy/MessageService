namespace NotifyManage
{
    partial class FrmNotityMessage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lcMessage = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // lcMessage
            // 
            this.lcMessage.Location = new System.Drawing.Point(56, 43);
            this.lcMessage.Name = "lcMessage";
            this.lcMessage.Size = new System.Drawing.Size(70, 14);
            this.lcMessage.TabIndex = 0;
            this.lcMessage.Text = "labelControl1";
            // 
            // FrmNotityMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 109);
            this.Controls.Add(this.lcMessage);
            this.Name = "FrmNotityMessage";
            this.Text = "FrmNotityMessage";
            this.Load += new System.EventHandler(this.FrmNotityMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lcMessage;
    }
}