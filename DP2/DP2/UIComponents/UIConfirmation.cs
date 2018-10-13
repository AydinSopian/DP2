using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP2
{
    public partial class confirmation1 : Form
    {
        private Boolean confirmed;

        public confirmation1()
        {
            InitializeComponent();
            confirmed = false;
        }

        public Boolean isConfirmed
        {
            get { return confirmed; }
            set { confirmed = value; }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            confirmed = false;
            this.Close();
        }

        private void buttonConfirmationContinue_Click(object sender, EventArgs e)
        {
            confirmed = true;
            this.Close();
        }

        private void buttonConfirmationCancel_Click(object sender, EventArgs e)
        {
            confirmed = false;
            this.Close();
        }
    }
}
