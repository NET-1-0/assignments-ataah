using gridViewExample.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gridViewExample
{
    public partial class HospitalGridView : System.Web.UI.Page
    {

        /* Calling an instance of the CRUD class so that it can be used in the GridBind Method
         * Since CRUD is being called within the class level, rather than a particular method, it can be used in any method within this class
         */
        CRUD cr = new CRUD();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                GridBind();

            }

        }

        // Creating a GridBind method that can be reused
        public void GridBind()
        {

            DataTable dt = new DataTable();
            dt = cr.GetHospitals();
            gvHospital.DataSource = dt;
            gvHospital.DataBind();

        }

        protected void gvHospital_RowEditing(object sender, GridViewEditEventArgs e)
        {

            gvHospital.EditIndex = e.NewEditIndex;
            GridBind();

        }

        protected void gvHospital_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            Label id = (Label)gvHospital.Rows[e.RowIndex].FindControl("lblID");
            int hid = int.Parse(id.Text);
            lblShow.Text = cr.DelHos(hid);
            GridBind();

        }

        protected void gvHospital_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

            gvHospital.EditIndex = -1;
            GridBind();

        }

        protected void gvHospital_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            Label id = (Label)gvHospital.Rows[e.RowIndex].FindControl("lblID");
            TextBox name = (TextBox)gvHospital.Rows[e.RowIndex].FindControl("txtName");
            TextBox city = (TextBox)gvHospital.Rows[e.RowIndex].FindControl("txtCity");
            int hid = int.Parse(id.Text);
            lblShow.Text = cr.UpdateHos(int.Parse(id.Text), name.Text, city.Text);
            gvHospital.EditIndex = -1;
            GridBind();

        }

    }
}