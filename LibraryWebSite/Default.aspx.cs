using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;//Add three namespace
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    private string strcon = WebConfigurationManager.ConnectionStrings["LibraryConnectionString1"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    /*
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "spSelectItemByTitle";
        cmd.Parameters.AddWithValue("@param1", TextBoxTitle.Text);
       
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("<script language='javascript'>alert('SQL Succeeds.');</script>");
        }

        catch (Exception er)
        {
            Response.Write("<script language='javascript'>alert('Title containg string was not found in library items.');</script>");
        }
        finally
        {
            con.Close();
            GridView2.DataBind();
        }
    }*/
    protected void TextBoxTitle_TextChanged(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "spSelectItemByTitle";
        cmd.Parameters.AddWithValue("@param1", TextBoxTitle.Text);

        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
            // Response.Write("<script language='javascript'>alert('SQL Succeeds.');</script>");
        }

        catch (Exception er)
        {
            Response.Write("<script language='javascript'>alert('Title containg string was not found in library items.');</script>");
        }
        finally
        {
            con.Close();
            GridView2.DataBind();
        }
    }
}