using Microsoft.AspNet.SignalR;
using SignalR.Learning.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalR.Learning.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Send()
        {
            return View();
        }

        public ActionResult SendMessage(string message)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<ChatHub>();
            context.Clients.All.writeMessage(message);

            return Content("0");
        }
    }
}