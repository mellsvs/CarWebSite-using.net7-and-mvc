using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using WebDers.Service.DTO;
using WebDers.Service.Models;

namespace WebDers.Controllers
{
    public class ControllerBase : Controller
    {

        public SessionInfo UserSession
        {
            get
            {
                var value = HttpContext.Session.GetString("UserSessionInfo");
                return value == null? default(SessionInfo) : JsonConvert.DeserializeObject<SessionInfo>(value);

            }

            set
            {
                JsonSerializerSettings jss = new JsonSerializerSettings();
                var JsonString = JsonConvert.SerializeObject(value);
                HttpContext.Session.SetString("UserSessionInfo", JsonString);
            }
        }
        public bool IsSessionAlive
        {
            get
            {
                return UserSession != null;
            }
        }
        public void ClearSession()
        {
            UserSession = null;
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (IsSessionAlive == false)
            {
                filterContext.Result = RedirectToLoginPage();
                return;
            }
            base.OnActionExecuting(filterContext);
        }
        public IActionResult RedirectToLoginPage(string redirectAction = "Index")
        {
            return RedirectToAction("IndexGiris", "Login", new { redirectAction = redirectAction });
        }

    }
}
