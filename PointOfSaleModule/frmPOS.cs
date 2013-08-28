using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PointOfSaleModule
{
    public partial class frmPOS : Form
    {
        private string currentUser;
        private string serverName;
        private string userName;
        private string userPassword;
        private string databaseName;
        private string connString;
        public frmPOS(String _current, String _server, String _username, String _password, String _database)
        {
            
             currentUser = _current;
             serverName = _server;
             userName = _username;
             userPassword = _password;
             databaseName = _database;
            // SET CONNECTION STRING
            connString = "Data Source=" +
                 serverName + ";Initial Catalog=" + 
                 databaseName + ";Persist Security Info=True;User ID=" +
                 userName + ";Password=" + 
                 userPassword + "";

            InitializeComponent();
            tsCurrentUser.Text += "" + currentUser;
            
        }

        public frmPOS()
        {
            InitializeComponent();
        }

        
    }
}
