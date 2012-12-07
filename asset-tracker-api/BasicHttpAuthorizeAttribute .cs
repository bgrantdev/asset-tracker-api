using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Web.Security;
using System.Security.Principal;
using System.Text;


namespace asset_tracker_api
{
    public class BasicHttpAuthorizeAttribute : AuthorizeAttribute
    {
        private const string BasicAuthHeaderResponse = "WWW-Authentic";
        private const string BasicAuthHeaderResponseValue = "Basic";

        public override void OnAuthorization(HttpActionContext actionContext)
        {
            //base.OnAuthorization(actionContext);
            if (actionContext == null)
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
            //base.HandleUnauthorizedRequest(actionContext);
            if (actionContext == null)
            {
                throw new ArgumentNullException("actionContext");
            }
            else
            {
                actionContext.Response = CreateUnauthorizedResponse(actionContext.ControllerContext.Request);
                actionContext.Response.Content = new StringContent("UnathorizedRequest");
            }
        }

        private HttpResponseMessage CreateUnauthorizedResponse(HttpRequestMessage httpRequestMessage)
        {
            var response = new HttpResponseMessage()
            {
                StatusCode = System.Net.HttpStatusCode.Unauthorized,
                RequestMessage = httpRequestMessage,
            };
            response.Headers.Add(BasicAuthHeaderResponse, BasicAuthHeaderResponseValue);
            return response;
        }


        private bool AuthorizeRequest(HttpRequestMessage httpRequestMessage)
        {
            AuthenticationHeaderValue value = httpRequestMessage.Headers.Authorization;
            if (value == null || String.IsNullOrWhiteSpace(value.Parameter) || String.IsNullOrWhiteSpace(value.Scheme) || value.Scheme != BasicAuthHeaderResponseValue)
            {
                return false;
            }

            string[] parsedHeader = ParseAuthorizationHeader(value.Parameter);
            if (parsedHeader == null)
            {
                return false;
            }
            IPrincipal principal = null;
            if (TryCreatePrincipal(parsedHeader[0], parsedHeader[1], out principal))
            {
                HttpContext.Current.User = principal;
                return ChekRoles(principal) && CheckUsers(principal);
            }
            else
            {
                return false;
            }
        }

        private bool CheckUsers(IPrincipal principal)
        {
            String[] users = UsersSplit;
            if (users.Length == 0)
            {
                return true;
            }
            else
            {
                return users.Any(u => principal.Identity.Name == u);
            }
        }

        private bool ChekRoles(IPrincipal principal)
        {
            string[] roles = RolesSplit;
            if (roles.Length == 0)
            {
                return true;
            }
            else
            {
                return roles.Any(principal.IsInRole);
            }
        }

        private string[] ParseAuthorizationHeader(string authHeader)
        {
            string [] credentials = Encoding.ASCII.GetString(Convert.FromBase64String(authHeader)).Split(new[] { ':' });
            if (credentials.Length != 2 || String.IsNullOrEmpty(credentials[0]) || String.IsNullOrEmpty(credentials[1]))
            {
                return null;
            }
            else
            {
                return credentials;
            }
        }

        private bool AuthorizationDisabled(HttpActionContext actionContext)
        {
            return false;
        }

        protected string[] RolesSplit
        {
            get { return SplitStrings(Roles); }
        }

        protected string[] UsersSplit
        {
            get { return SplitStrings(Users); }
        }

        protected static string[] SplitStrings(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return new string[0];
            }
            else
            {
                var result = input.Split(',').Where(s => !String.IsNullOrWhiteSpace(s.Trim()));
                return result.Select(s => s.Trim()).ToArray();
            }
        }

        protected  bool TryCreatePrincipal(string user, string password, out IPrincipal principal)
        {
            principal = null;
            if (!Membership.Provider.ValidateUser(user, password))
            {
                return false;
            }
            else
            {
                string[] roles = System.Web.Security.Roles.Provider.GetRolesForUser(user);
                principal = new GenericPrincipal(new GenericIdentity(user), roles);
                return true;
            }
        }
    }
}