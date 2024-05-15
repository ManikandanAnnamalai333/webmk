using System;
using System.Collections.Generic;
using System. Linq;
using System. Web;
using System.Web.UI;
using System. Web. UI.WebControls;

namespace sample
{
    public partial class simple: System.Web. UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hi Sudarshan";
        }
    }
}