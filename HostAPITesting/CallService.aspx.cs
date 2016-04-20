using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HostAPITesting
{
    public partial class CallService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HostAPITesting.HostTrackerAPI.UserService API = new HostTrackerAPI.UserService();
            API.SignIn("appanalyst@mdec.com.my", "N@jib1607");
            HostTrackingAPI.HttpTask task = new HostTrackingAPI.HttpTask();
        }
    }
}