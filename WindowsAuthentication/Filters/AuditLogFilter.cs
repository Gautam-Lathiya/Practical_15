using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WindowsAuthentication.Data;
using WindowsAuthentication.Models;

namespace WindowsAuthentication.Filters
{
    public class AuditLogFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var username = filterContext.HttpContext.User.Identity.Name;
            var url = filterContext.HttpContext.Request.Url.ToString();
            var log = new AuditLog
            {
                Username = username,
                UrlAccessed = url,
                AccessTime = DateTime.Now
            };

            using (var db = new AuditLogContext())
            {
                db.AuditLogs.Add(log);
                db.SaveChanges();
            }

            base.OnActionExecuted(filterContext);
        }
    }
}