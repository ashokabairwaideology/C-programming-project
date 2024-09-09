using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LiveDocs.net.Include
{
    public partial class Menu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnBold.Attributes.Add("onClick","buttonClick(this.id); return false;");
            btnItalic.Attributes.Add("onClick", "buttonClick(this.id); return false;");
            btnUnderline.Attributes.Add("onClick", "buttonClick(this.id); return false;");
        }
    }
}