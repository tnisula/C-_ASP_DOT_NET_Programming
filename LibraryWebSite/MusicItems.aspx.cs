using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;//Add three namespace
using System.Data;
using System.Data.SqlClient;

public partial class MusicItems : System.Web.UI.Page
{
    private string strcon = WebConfigurationManager.ConnectionStrings["LibraryConnectionString1"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonUpdate_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "spUpdateMusic";
        // cmd.Parameters.AddWithValue("@id", TextBoxId.Text);
        cmd.Parameters.AddWithValue("@id", GridView1.SelectedRow.Cells[1].Text); 
        cmd.Parameters.AddWithValue("@type", "Music");
        cmd.Parameters.AddWithValue("@state", DropDownListState.SelectedValue);
        cmd.Parameters.AddWithValue("@author", TextBoxAuthor.Text);
        cmd.Parameters.AddWithValue("@title", TextBoxTitle.Text);
        cmd.Parameters.AddWithValue("@publisher", TextBoxPublisher.Text);
        cmd.Parameters.AddWithValue("@classification", TextBoxClassification.Text);
        cmd.Parameters.AddWithValue("@genre", TextBoxGenre.Text);
        // cmd.Parameters.AddWithValue("@borrowdate", null);
        cmd.Parameters.AddWithValue("@isrc", TextBoxISRC.Text);
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
            DropDownListState.SelectedValue = "Free";
            TextBoxAuthor.Text = "";
            TextBoxTitle.Text = "";
            TextBoxPublisher.Text = "";
            TextBoxClassification.Text = "";
            TextBoxGenre.Text = "";
            TextBoxISRC.Text = "";
        }
    }
    protected void ButtonDelete_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "spDeleteMusic";
        // cmd.Parameters.AddWithValue("@id", TextBoxId.Text);
        cmd.Parameters.AddWithValue("@id", GridView1.SelectedRow.Cells[1].Text);
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("<script language='javascript'>alert('Record has been deleted.');</script>");
        }
        catch (Exception er)
        {
            Response.Write("<script language='javascript'>alert('Could not delete music in ID.');</script>");
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
            TextBoxISRC.Text = "";
        }
    }
    protected void ButtonInsert_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "spInsertMusic";        
        cmd.Parameters.AddWithValue("@type", "Music");
        cmd.Parameters.AddWithValue("@state", DropDownListState.SelectedValue);
        cmd.Parameters.AddWithValue("@author", TextBoxAuthor.Text);
        cmd.Parameters.AddWithValue("@title", TextBoxTitle.Text);
        cmd.Parameters.AddWithValue("@publisher", TextBoxPublisher.Text);
        cmd.Parameters.AddWithValue("@classification", TextBoxClassification.Text);
        cmd.Parameters.AddWithValue("@genre", TextBoxGenre.Text);
        // cmd.Parameters.AddWithValue("@borrowdate", null);
        cmd.Parameters.AddWithValue("@isrc", TextBoxISRC.Text);
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
            DropDownListState.SelectedValue = "Free";
            TextBoxAuthor.Text = "";
            TextBoxTitle.Text = "";
            TextBoxPublisher.Text = "";
            TextBoxClassification.Text = "";
            TextBoxGenre.Text = "";
            TextBoxISRC.Text = "";
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        foreach(GridViewRow gr in GridView1.Rows) 
            gr.BackColor=System.Drawing.Color.White; 
        GridView1.SelectedRow.BackColor = System.Drawing.Color.Aquamarine;

        DropDownListState.SelectedValue = GridView1.SelectedRow.Cells[3].Text;
        TextBoxAuthor.Text = GridView1.SelectedRow.Cells[4].Text;
        TextBoxTitle.Text = GridView1.SelectedRow.Cells[5].Text;
        TextBoxPublisher.Text = GridView1.SelectedRow.Cells[6].Text;
        TextBoxClassification.Text = GridView1.SelectedRow.Cells[7].Text;
        TextBoxGenre.Text = GridView1.SelectedRow.Cells[8].Text;
        TextBoxISRC.Text = GridView1.SelectedRow.Cells[9].Text;
    }
}