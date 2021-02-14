using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TFMProject.MyDBServiceReference;

namespace TFMProject
{
    public partial class retrieveGroup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshGridView();
        }
        private void RefreshGridView()
        {
            List<Group> eList = new List<Group>();
            Service1Client client = new Service1Client();
            eList = client.GetAllGroup().ToList();

            // using gridview to bind to the list of employee objects
            gvGroup.Visible = true;
            gvGroup.DataSource = eList;
            gvGroup.DataBind();
        }
    }
}