using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TFMProject.MyDBServiceReference;
using System.Text;
using System.Web.ModelBinding;

namespace TFMProject
{
    public partial class groupPage : System.Web.UI.Page
    {
        private Label lblCount = new Label();
        protected void Page_Load(object sender, EventArgs e)
        {
            Service1Client client = new Service1Client();
            var query = client.GetAllGroup().ToList();
            foreach (Group grp in query)
            {
                Label l = new Label();
                l.Text = grp.Name;
                Panel1.Controls.Add(l);
                Panel1.Controls.Add(new LiteralControl("<br />"));
            }
        }

        public IQueryable<Group> GetAllItemGroup()
        {
            Service1Client client = new Service1Client();
            var query = client.GetAllGroup().AsQueryable();
            return query;
        }

      
    }
}