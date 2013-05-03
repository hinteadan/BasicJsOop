using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using Model.Projections;

namespace JsConcepts.Controllers
{
    public class BrowseController : BaseController
    {
        //
        // GET: /Browse/

        public ActionResult Index()
        {
            return View(Store.FetchAll<Contact>().AsContactBriefInfo()
                .OrderBy(c => c.FirstName)
                .ThenBy(c => c.LastName));
        }

    }
}
