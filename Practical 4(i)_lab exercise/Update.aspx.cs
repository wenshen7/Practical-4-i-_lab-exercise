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
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";

            SqlConnection conCustomer;
            string connStr = ConfigurationManager.ConnectionStrings["CustomerConn"].ConnectionString;
            conCustomer = new SqlConnection(connStr);
            conCustomer.Open();

            string strUpdate;
            SqlCommand cmdUpdate;
            strUpdate = "Update dbo.Customer Set ContactName= @Name, PhoneNum= @Phone Where CustomerID=" + Convert.ToInt32(txtID.Text);

            cmdUpdate = new SqlCommand(strUpdate, conCustomer);

            cmdUpdate.Parameters.AddWithValue("@ContactName", txtName.Text);
            cmdUpdate.Parameters.AddWithValue("@Phone", txtPhone.Text);

            int n = cmdUpdate.ExecuteNonQuery();

            if (n > 0)
                lblMsg.Text = "Customer's details have been updated!";
            else
                lblMsg.Text = "Sorry, update failed.";

            conCustomer.Close();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
        }
    }
}