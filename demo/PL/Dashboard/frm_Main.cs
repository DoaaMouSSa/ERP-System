using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo.PL.Dashboard
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        /******************* moveable **********************/
        int p0;
        int x;
        int y;

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            p0 = 1;
            x = e.X;
            y = e.Y;
        }

        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            p0 = 0;
        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (p0 == 1)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }
        /***********************************  end of moveable *****************************************/
        private void frm_Main_Load(object sender, EventArgs e)
        {
            //pnlSideBarMenu.BackColor = Color.Green;
            //PrivateFontCollection arabic_font = new PrivateFontCollection();
            //arabic_font.AddFontFile(@"G:\Vazirmatn-VariableFont_wght.ttf");
            //foreach(Control c in this.Controls)
            //{
            //    c.Font = new Font(arabic_font.Families[0], 15, FontStyle.Regular);
            //}

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {

        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
