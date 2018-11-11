using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;//Add three namespace
using System.Data;
using System.Data.SqlClient;

public partial class Books : System.Web.UI.Page
{
    private string strcon = WebConfigurationManager.ConnectionStrings["LibraryConnectionString1"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonSelect_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "spSelectBook";
        cmd.Parameters.AddWithValue("@param1", TextBoxId.Text);
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("<script language='javascript'>alert('Record has been updated.');</script>");

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "LibraryItems");
            // LabelId.Text = ds.Tables["LibraryItems"].Rows[0].ItemArray[0].ToString();
            DropDownListState.SelectedValue = ds.Tables["LibraryItems"].Rows[0].ItemArray[2].ToString();
            TextBoxAuthor.Text = ds.Tables["LibraryItems"].Rows[0].ItemArray[3].ToString();
            TextBoxTitle.Text = ds.Tables["LibraryItems"].Rows[0].ItemArray[4].ToString();
            TextBoxPublisher.Text = ds.Tables["LibraryItems"].Rows[0].ItemArray[5].ToString();
            TextBoxClassification.Text = ds.Tables["LibraryItems"].Rows[0].ItemArray[6].ToString();
            TextBoxGenre.Text = ds.Tables["LibraryItems"].Rows[0].ItemArray[7].ToString();
            TextBoxISBN.Text = ds.Tables["LibraryItems"].Rows[0].ItemArray[8].ToString();
        }
        catch (Exception er)
        {
            Response.Write("<script language='javascript'>alert('No book found in ID.');</script>");
        }
        finally
        {
            con.Close();
        }
    }
    protected void ButtonUpdate_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "spUpdateBook";
        cmd.Parameters.AddWithValue("@id", TextBoxId.Text);
        cmd.Parameters.AddWithValue("@type", "Book");
        cmd.Parameters.AddWithValue("@state", DropDownListState.SelectedValue);
        cmd.Parameters.AddWithValue("@author", TextBoxAuthor.Text);
        cmd.Parameters.AddWithValue("@title", TextBoxTitle.Text);
        cmd.Parameters.AddWithValue("@publisher", TextBoxPublisher.Text);
        cmd.Parameters.AddWithValue("@classification", TextBoxClassification.Text);
        cmd.Parameters.AddWithValue("@genre", TextBoxGenre.Text);
        // cmd.Parameters.AddWithValue("@borrowdate", null);
        cmd.Parameters.AddWithValue("@isbn", TextBoxISBN.Text);
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("<script language='javascript'>alert('Record has been updated.');</script>");
        }
        catch (Exception er)
        {
            Response.Write("<script language='javascript'>alert('Could not update record!');</script>");
        }
        finally
        {
            con.Close();
            GridView1.DataBind();
            // LabelId.Text = "";
            TextBoxId.Text = "";
            TextBoxAuthor.Text = "";
            TextBoxTitle.Text = "";
            TextBoxPublisher.Text = "";
            TextBoxClassification.Text = "";
            TextBoxGenre.Text = "";
            TextBoxISBN.Text = "";
        }
    }
    protected void ButtonDelete_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "spDeleteBook";
        cmd.Parameters.AddWithValue("@id", TextBoxId.Text);
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("<script language='javascript'>alert('Record has been deleted.');</script>");
       }
        catch (Exception er)
        {
            Response.Write("<script language='javascript'>alert('Could not delete book in ID.');</script>");
        }
        finally
        {
            con.Close();
            GridView1.DataBind();
            // LabelId.Text = "";
            DropDownListState.SelectedValue = "Free";
            TextBoxAuthor.Text = "";
            TextBoxTitle.Text = "";
            TextBoxPublisher.Text = "";
            TextBoxClassification.Text = "";
            TextBoxGenre.Text = "";
            TextBoxISBN.Text = "";
        }
    }
    protected void ButtonInsert_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "spInsertBook";
        // cmd.Parameters.AddWithValue("@id", TextBoxId.Text);
        cmd.Parameters.AddWithValue("@type", "Book");
        cmd.Parameters.AddWithValue("@state", DropDownListState.SelectedValue);
        cmd.Parameters.AddWithValue("@author", TextBoxAuthor.Text);
        cmd.Parameters.AddWithValue("@title", TextBoxTitle.Text);
        cmd.Parameters.AddWithValue("@publisher", TextBoxPublisher.Text);
        cmd.Parameters.AddWithValue("@classification", TextBoxClassification.Text);
        cmd.Parameters.AddWithValue("@genre", TextBoxGenre.Text);
        // cmd.Parameters.AddWithValue("@borrowdate", null);
        cmd.Parameters.AddWithValue("@isbn", TextBoxISBN.Text);
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("<script language='javascript'>alert('Record has been inserted.');</script>");
        }
        catch (Exception er)
        {
            Response.Write("<script language='javascript'>alert('Could not insert record!');</script>");
        }
        finally
        {
            con.Close();
            GridView1.DataBind();
            /*
            // LabelId.Text = "";
            TextBoxId.Text = "";
            TextBoxAuthor.Text = "";
            TextBoxTitle.Text = "";
            TextBoxPublisher.Text = "";
            TextBoxClassification.Text = "";
            TextBoxGenre.Text = "";
            TextBoxISBN.Text = ""; */
        }
    }
}