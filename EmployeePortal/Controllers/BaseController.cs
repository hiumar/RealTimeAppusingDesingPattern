using LogWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeePortal.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        private ILogger _logger;
    
        public BaseController()
        {
            _logger = Log.GetInstance;
        }
        protected override void OnException(ExceptionContext filterContext)
        {
            _logger.LogException(filterContext.Exception.ToString());
            filterContext.ExceptionHandled = true;
            this.View("Error").ExecuteResult(this.ControllerContext);
        }
    }
}