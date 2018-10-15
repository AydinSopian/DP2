using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP2.UIComponents
{
    public partial class UIError : Form
    {
        public UIError(string message, string ok)
        {
            InitializeComponent();
            this.labelError.Text = message;
            this.buttonErrorOK.Text = ok;
        }

        private void buttonErrorOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
