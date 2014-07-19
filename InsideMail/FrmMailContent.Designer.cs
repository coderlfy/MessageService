namespace InsideMail
{
    partial class FrmMailContent
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
            this.lbMailFrom = new System.Windows.Forms.Label();
            this.lbMailContent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbMailFrom
            // 
            this.lbMailFrom.AutoSize = true;
            this.lbMailFrom.Location = new System.Drawing.Point(49, 70);
            this.lbMailFrom.Name = "lbMailFrom";
            this.lbMailFrom.Size = new System.Drawing.Size(41, 12);
            this.lbMailFrom.TabIndex = 0;
            this.lbMailFrom.Text = "label1";
            // 
            // lbMailContent
            // 
            this.lbMailContent.AutoSize = true;
            this.lbMailContent.Location = new System.Drawing.Point(51, 132);
            this.lbMailContent.Name = "lbMailContent";
            this.lbMailContent.Size = new System.Drawing.Size(41, 12);
            this.lbMailContent.TabIndex = 1;
            this.lbMailContent.Text = "label2";
            // 
            // FrmMailContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lbMailContent);
            this.Controls.Add(this.lbMailFrom);
            this.Name = "FrmMailContent";
            this.Text = "FrmMailContent";
            this.Load += new System.EventHandler(this.FrmMailContent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMailFrom;
        private System.Windows.Forms.Label lbMailContent;
    }
}