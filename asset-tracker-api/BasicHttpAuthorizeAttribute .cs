using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;


namespace asset_tracker_api
{
    public class BasicHttpAuthorizeAttribute : AuthorizeAttribute
    {
        private const string BasicAuthHeaderResponse = "WWW-Authentic";
        private const string BasicAuthHeaderResponseValue = "Basic";

        public override void OnAuthorization(HttpActionContext actionContext)
        {
            base.OnAuthorization(actionContext);
            if (actionContext != null)
            {
                throw new ArgumentNullException("actionContext");
            }
            if (AuthorizationDisabled(actionContext) || AuthorizeRequest(actionContext.ControllerContext.Request))
            {
                return;
            }
            else 
            {
                this.HandleUnauthorizedRequest(actionContext);
            }
        }

        protected override void HandleUnauthorizedRequest(HttpActionContext actionContext)
        {
            base.HandleUnauthorizedRequest(actionContext);
            if (actionContext == null)
            {
                throw new ArgumentNullException("actionContext");
            }
            else
            {
                actionContext.Response = CreateUnauthorizedResponse(actionContext.ControllerContext.Request);
            }
        }

        private HttpResponseMessage CreateUnauthorizedResponse(HttpRequestMessage httpRequestMessage)
        {
            var response = new HttpResponseMessage()
            {
                StatusCode = System.Net.HttpStatusCode.Unauthorized,
                RequestMessage = httpRequestMessage;
            };
            response.Headers.Add(BasicAuthHeaderResponse, BasicAuthHeaderResponseValue);
            return response;
        }


        private bool AuthorizeRequest(HttpRequestMessage httpRequestMessage)
        {
            AuthenticationHeaderValue value = httpRequestMessage.Headers.Authorization;
            if (value == null || String.IsNullOrWhiteSpace(value.Parameter) || 
        }

        private bool AuthorizationDisabled(HttpActionContext actionContext)
        {
            return true;
        }

    }
}