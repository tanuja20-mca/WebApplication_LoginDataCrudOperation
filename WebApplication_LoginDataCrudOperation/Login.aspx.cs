using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_LoginDataCrudOperation
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=LoginCRUDOperation;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

            con.Open();

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("insert into Login values('" + txtID.Text + " ','" + txtName.Text + "','" + txtCourse.Text + "','" + txtAddress.Text + "')", con);
            
            cmd.ExecuteNonQuery();

            txtID.Text = "";
            txtName.Text = "";
            txtCourse.Text = "";
            txtAddress.Text = "";
            Response.Write("<script>alert('Record Inserted Successfully')</script>");
            

        }
        public void display_Data()
        {

            SqlCommand cmd = new SqlCommand("select * from Login", con);

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Login set Name= '" + txtName.Text + "' , Course='" + txtCourse.Text + " ', 	Address='" + txtAddress.Text + "' where id=" + Convert.ToInt32(txtID.Text) + "", con);

            cmd.ExecuteNonQuery();

            txtID.Text = "";
            txtName.Text = "";
            txtCourse.Text = "";
            txtAddress.Text = "";
            Response.Write("<script>alert('Record Updated Successfully')</script>");
            display_Data();

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("delete from Login where Id= '" + txtID.Text + " '", con);

            cmd.ExecuteNonQuery();

            txtID.Text = "";

            Response.Write("<script>alert('Record Deleted Successfully')</script>");

        }

        protected void lblSelect_Click(object sender, EventArgs e)
        {
            display_Data();

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Login where Id='" + txtID.Text + " '", con);

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}