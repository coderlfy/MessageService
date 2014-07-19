using Message.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SystemInterface;

namespace InsideMail
{
    public partial class FrmMailContent : ExtForm
    {

        private Mail _mail;

        public Mail _Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }
        
        public FrmMailContent()
        {
            InitializeComponent();
            _Mail = new Mail();
        }

        private void FrmMailContent_Load(object sender, EventArgs e)
        {
            base.AssignToParams(this);
            this.lbMailContent.Text = this._Mail._Content;
            this.lbMailFrom.Text = this._Mail._From;
        }

        
    }
}
