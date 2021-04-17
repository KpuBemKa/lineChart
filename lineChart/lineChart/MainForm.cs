using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lineChart
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void InsertDataButton_Click(object sender, EventArgs e)
        {
            InsertData insertData = new InsertData();

            insertData.ShowDialog();
        }

        private void DeleteDataButton_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            connectionString = "Data Source=ADMIN-PC;Initial Catalog=METRO Cash&Carry;User ID=troj;Password=1";

            SqlConnection cnn;

            try
            {
                cnn = new SqlConnection(connectionString);
                cnn.Open();

                string sql = "SELECT * FROM information_schema.tables;";
                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataReader dataReader = command.ExecuteReader();

                while(dataReader.Read())
                {
                    MessageBox.Show(dataReader.GetValue(2).ToString());
                }

                dataReader.Close();
                command.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection!");
            }
        }
    }
}
