using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PurchasingModule
{
    public partial class frmPurchasing : Form
    {
        private string currentUser;
        private string serverName;
        private string userName;
        private string userPassword;
        private string databaseName;
        private string connString;
        public frmPurchasing(String _current, String _server, String _username, String _password, String _database)
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

        public frmPurchasing()
        {
            InitializeComponent();
        }

        private void frmPurchasing_Load(object sender, EventArgs e)
        {
            testDatabase();
        }

        private void testDatabase()
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand sqlcommand = new SqlCommand("SELECT * FROM [TestPOS].[dbo].[pur_stocks]", conn);
            SqlDataReader data;

            try
            {
                conn.Open();
                data = sqlcommand.ExecuteReader();
                while (data.Read())
                {
                    for (int i = 0; i < data.FieldCount - 1; i++)
                    {
                        Console.WriteLine(data[i].ToString());
                    }
                    dgvPurchasing.Rows.Add(data);
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmAddItem addItem = new frmAddItem();
            addItem.ShowDialog();
        }

       
    }
}
