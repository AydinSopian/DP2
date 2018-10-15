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
    public partial class UIConfirmation : Form
    {
        private Boolean _confirmed;

        public UIConfirmation()
        {
            InitializeComponent();
            _confirmed = false;
        }

        public UIConfirmation(string message, string yes, string no)
        {
            InitializeComponent();
            _confirmed = false;
            this.labelConfirmation.Text = message;
            this.buttonConfirmationContinue.Text = yes;
            this.buttonConfirmationCancel.Text = no;
        }

        public Boolean isConfirmed
        {
            get { return _confirmed; }
            set { _confirmed = value; }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            _confirmed = false;
            this.Close();
        }

        private void buttonConfirmationContinue_Click(object sender, EventArgs e)
        {
            _confirmed = true;
            this.Close();
        }

        private void buttonConfirmationCancel_Click(object sender, EventArgs e)
        {
            _confirmed = false;
            this.Close();
        }
    }
}
