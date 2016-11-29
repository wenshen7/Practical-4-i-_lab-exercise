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
    public partial class Display : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            /*Initialize text value to empty*/
            txtID.Text = "";
            txtCompany.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";

            /*Step 1: Create and Open Connection*/
            SqlConnection conCustomer;
            string connStr = ConfigurationManager.ConnectionStrings["CustomerConn"].ConnectionString;
            conCustomer = new SqlConnection(connStr);
            conCustomer.Open();

            /*Step 2: SQL Command object to retrieve data from Customer table*/
            string strSelect;
            SqlCommand cmdSelect;

            strSelect = "Select * From dbo.Customer Where CustomerID=" + Convert.ToInt32(txtID.Text);
            cmdSelect = new SqlCommand(strSelect, conCustomer);

            /*Step 3: Execute command to retrive data*/
            SqlDataReader dtr;
            dtr = cmdSelect.ExecuteReader();

            /*Step 4: Display result set from the query*/
            if (dtr.HasRows)
            {
                while (dtr.Read())
                {
                    txtCompany.Text = dtr["CompanyName"].ToString();
                    txtName.Text = dtr["CustomerName"].ToString();
                    txtPhone.Text = dtr["Phone"].ToString();
                }
            }
            else
            {
                txtCompany.Text = "NIL";
                txtName.Text = "NIL";
                txtPhone.Text = "NIL";
            }

            /*Step 5: Close SqlReader and Database connection*/
            conCustomer.Close();
            dtr.Close();
        }
    }
}