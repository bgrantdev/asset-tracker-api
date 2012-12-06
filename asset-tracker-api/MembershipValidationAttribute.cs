using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace asset_tracker_api
{
    public class MembershipValidationAttribute :  BasicHttpAuthorizeAttribute
    {
    }
}