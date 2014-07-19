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

namespace NotifyManage
{
    public partial class FrmNotityMessage : ExtForm
    {
        private NotifyMessage _notify;

        public NotifyMessage _Notify
        {
            get { return _notify; }
            set { _notify = value; }
        }
        
        
        public FrmNotityMessage()
        {
            InitializeComponent();

            _Notify = new NotifyMessage();
        }

        private void FrmNotityMessage_Load(object sender, EventArgs e)
        {
            base.AssignToParams(this);
            this.lcMessage.Text = this._Notify._Message;
        }

    }
}
