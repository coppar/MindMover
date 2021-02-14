using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TFMProject.MyDBServiceReference;

namespace TFMProject
{
    public partial class searchGroup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnGetGroup_Click(object sender, EventArgs e)
        {
            LoadCustomer();
        }
        protected void LoadCustomer()
        {
            MyDBServiceReference.Service1Client client = new MyDBServiceReference.Service1Client();
            Group grpObj = client.GetGroupById(tb_grpId.Text);
            if (grpObj != null)
            {
                PanelErrorResult.Visible = false;
                PanelCust.Visible = true;
                lb_id.Text = grpObj.Id;
                lb_name.Text = grpObj.Name;
                lb_description.Text = grpObj.Description;
                lb_createdAt.Text = grpObj.CreatedAt.ToString();
                lb_deleted.Text = grpObj.Deleted;
                Lbl_err.Text = String.Empty;
            }
            else
            {
                Lbl_err.Text = "Group record not found!";
                PanelErrorResult.Visible = true;
                PanelCust.Visible = false;
                lb_id.Text = String.Empty;
                lb_name.Text = String.Empty;
                lb_description.Text = String.Empty;
                lb_createdAt.Text = String.Empty;
                lb_deleted.Text = String.Empty;
            }
        }

    }
}