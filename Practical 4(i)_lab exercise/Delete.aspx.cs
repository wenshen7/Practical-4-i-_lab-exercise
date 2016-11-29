using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Practical_4_i__lab_exercise
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conCustomer;
            string connStr = ConfigurationManager.ConnectionStrings["CustomerConn"].ConnectionString;
            conCustomer = new SqlConnection(connStr);
            conCustomer.Open();

            string strSelect;
            SqlCommand cmdSelect;

            strSelect = "Delete From dbo.Customer Where CustomerID =" + Convert.ToInt32(txtID.Text);
            cmdSelect = new SqlCommand(strSelect, conCustomer);

            SqlDataReader dtr;
            dtr = cmdSelect.ExecuteReader();

            if (dtr.HasRows)
            {
                while (dtr.Read())
                {
                    lblMsg.Text += dtr["CompanyName"].ToString() + "," +
                                    dtr["ContactName"].ToString() + "," +
                                    dtr["Phone"].ToString() + " have been deleted.";
                }
            }

            conCustomer.Close();
            dtr.Close();

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
        }
    }
}