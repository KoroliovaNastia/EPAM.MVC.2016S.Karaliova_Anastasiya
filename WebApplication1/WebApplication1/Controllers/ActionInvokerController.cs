using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Infrastructure;

namespace WebApplication1.Controllers
{
    public class ActionInvokerController : Controller
    {
        // GET: ActionInvoker
        public ActionInvokerController()
        {
            this.ActionInvoker = new CustomActionInvoker();
        }
    }
}