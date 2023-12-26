using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo.PL.Message
{
    public partial class frm_MessageYesNo : Form
    {
        public frm_MessageYesNo()
        {
            InitializeComponent();
        }

        public Image MessageIcon
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }
        public string MessageBody
        {
            get { return lb_message.Text; }
            set { lb_message.Text = value; }
        }
    }
}
