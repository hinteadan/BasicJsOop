using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelStore;

namespace JsConcepts.Controllers
{
    public class BaseController : Controller
    {
        protected InMemoryStore Store
        {
            get
            {
                return HttpContext.Application["Store"] as InMemoryStore;
            }
        }
    }
}