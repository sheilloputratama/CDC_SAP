using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AkademikADOApp
{
 
    public partial class Form1 : Form
    {
        string connString =
       "Data Source=LAPTOP-54NIAI63\\SHEILLOAGRA;Initial Catalog=DBAkademikADO;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }
        //Object sqlConnection
        SqlConnection conn = null;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
             
    }
}
