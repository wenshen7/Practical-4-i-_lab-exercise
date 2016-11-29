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
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtCompany.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            /*Initialize textbox to empy*/
            txtCompany.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";

            /*Step 1: Create and Open Connection*/
            SqlConnection conCustomer;
            string connStr = ConfigurationManager.ConnectionStrings["CustomerConn"].ConnectionString;
            conCustomer = new SqlConnection(connStr);
            conCustomer.Open();

            /*Step 2: Create Sql Insert statement and Sql Insert Object*/
            string strInsert;
            SqlCommand cmdInsert;
            strInsert = "Insert Into Customer (CompanyName, ContactName, Phone) Values (@CompanyName, @ContactName, @Phone)";

            cmdInsert = new SqlCommand(strInsert, conCustomer);
            cmdInsert.Parameters.AddWithValue("@CompanyName", txtCompany.Text);
            cmdInsert.Parameters.AddWithValue("@ContactName", txtName.Text);
            cmdInsert.Parameters.AddWithValue("@Phone", txtPhone.Text);

            /*Step 3: Execute command to insert*/
            int n = cmdInsert.ExecuteNonQuery();

            /*Display insert status*/
            if (n > 0)
                lblMsg.Text = "New customer added!";
            else
                lblMsg.Text = "Sorry, insertion failed";

            /*Step 4: Close database connection*/
            conCustomer.Close();
        }
    }
}