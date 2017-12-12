using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySqlMapping
{
    public partial class ConnectMySql : Form
    {
        string database;
        string localhost;
        string username;
        string password;

        public static MySqlConnection mySqlInstance;

        public ConnectMySql()
        {
            InitializeComponent();
            mySqlInstance = null;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnConnectDB_Click(object sender, EventArgs e)
        {
            ConnectDB();
        }

        private void BntDisconnectDB_Click(object sender, EventArgs e)
        {
            DisConnectDB();
        }

        public void ConnectDB()
        {
            //localhost = "localhost";
            localhost = "127.0.0.1"; //Not need port 3306 ???
            database = "SimpleData";
            username = "root";
            password = "admin";

            string connectString = "SERVER=" + localhost + ";" +
                "DATABASE=" + database +";" +
                "UID=" + username + ";" +
                "PASSWORD=" + password + ";";

            //if(mySqlInstance.State )
            //if (mySqlInstance != null)
            //    return;
            mySqlInstance = new MySqlConnection(connectString);
            //string state = Convert.ToString(mySqlInstance.State);
            //MessageBox.Show(state);//Close ConnectionTimeout
            if (mySqlInstance.State == ConnectionState.Closed)
            {
                mySqlInstance.Open(); //Finish connect database server
            }

            //Time for trying connect to database server.
            //string timeOut = Convert.ToString(mySqlInstance.ConnectionTimeout);
            //MessageBox.Show(timeOut);
        }


        public void DisConnectDB()
        {
            //string state = Convert.ToString(mySqlInstance.State);
            //MessageBox.Show(state);

            //if (mySqlInstance.State == ConnectionState.Open)
            //{
                   //connection state change to close.
            //    mySqlInstance.Close(); //Difference with kill connection or disconnect
            //}

            if (mySqlInstance.State == ConnectionState.Open)
            {
                mySqlInstance.Dispose(); //connection state change to close.
                //MySqlConnection.ClearAllPools(); //this is kill-connection
                MySqlConnection.ClearPool(mySqlInstance); //this is kill-connection
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textID.Text);
        }
    }
}
