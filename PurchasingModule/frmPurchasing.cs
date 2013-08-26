using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace PurchasingModule
{
    public partial class frmPurchasing : Form
    {
        public frmPurchasing(String _current) 
        {
            
            String currentUser = _current;

            InitializeComponent();
            tsCurrentUser.Text += "" + currentUser;
        }

        public frmPurchasing()
        {
            InitializeComponent();
        }

       
    }
}
