using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TFMProject.MyDBServiceReference;

namespace TFMProject
{
    public partial class addGroup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        private bool ValidateInput()
        {
            bool result;
            lbMsg.Text = String.Empty;
            lbMsg.ForeColor = Color.Red;

            MyDBServiceReference.Service1Client client = new MyDBServiceReference.Service1Client();
            Group grp = client.GetGroupById(tbName.Text);
            if (grp != null)
            {
                lbMsg.Text += "Group already exists!" + "<br/>";
            }
            if (String.IsNullOrEmpty(tbName.Text))
            {
                lbMsg.Text += "Name is required!" + "<br/>";
            }
            if (String.IsNullOrEmpty(tbDesc.Text))
            {
                lbMsg.Text += "Description is required!" + "<br/>";
            }
            if (String.IsNullOrEmpty(lbMsg.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            bool validInput = ValidateInput();

            if (validInput)
            {
                MyDBServiceReference.Service1Client client = new Service1Client();
                int result = client.CreateGroup(tbName.Text, tbDesc.Text);
                if (result == 1)
                {
                    lbMsg.ForeColor = Color.Green;
                    lbMsg.Text = "Group Record Inserted Successfully!";
                }
                else
                    lbMsg.Text = "SQL Error. Insert Unsuccessful!";
            }
            Response.Redirect("retrieveGroup.aspx");
        }

    }
}
