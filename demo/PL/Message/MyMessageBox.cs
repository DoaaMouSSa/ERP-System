using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.PL.Message
{
    public static class MyMessageBox
    {
        public static System.Windows.Forms.DialogResult ShowMessage (string message, string caption, System.Windows.Forms.MessageBoxButtons button, System.Windows.Forms.MessageBoxIcon icon)
        {
            System.Windows.Forms.DialogResult dialogResult = System.Windows.Forms.DialogResult.None;
            switch(button)
            {
                case System.Windows.Forms.MessageBoxButtons.OK:
                    using(frm_MessageOK messageOK = new frm_MessageOK())
                    {
                        messageOK.Text = caption;
                        messageOK.MessageBody = message;
                        switch(icon)
                        {
                            case System.Windows.Forms.MessageBoxIcon.Information:
                                messageOK.MessageIcon = demo.Properties.Resources.information;
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Question:
                                messageOK.MessageIcon = demo.Properties.Resources.question;
                                break;

                        }
                        dialogResult = messageOK.ShowDialog();
                    }
                    break;
                case System.Windows.Forms.MessageBoxButtons.YesNo:
                    using (frm_MessageYesNo messageYesNo = new frm_MessageYesNo())
                    {
                        messageYesNo.Text = caption;
                        messageYesNo.MessageBody = message;
                        switch (icon)
                        {
                            case System.Windows.Forms.MessageBoxIcon.Information:
                                messageYesNo.MessageIcon = demo.Properties.Resources.information;
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Question:
                                messageYesNo.MessageIcon = demo.Properties.Resources.question;
                                break;

                        }
                        dialogResult = messageYesNo.ShowDialog();
                    }
                    break;
            }
            return dialogResult;
        }
            

    }
}
