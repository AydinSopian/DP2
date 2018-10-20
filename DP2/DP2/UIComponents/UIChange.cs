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
    public partial class UIChange : Form
    {
        private UIPayment _parentForm;
        private decimal _change;

        public UIChange(UIPayment parentForm)
        {    
            InitializeComponent();
            _parentForm = parentForm;
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPaymentConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UIChange_Load(object sender, EventArgs e)
        {
            _change = _parentForm.AmountPaid - _parentForm.SalesTotal;
            labelChangeChange.Text = "RM " + _change.ToString();
        }
    }
}
