using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using Model.Projections;

namespace JsConcepts.Controllers
{
    public class ContactsController : BaseController
    {
        public ActionResult Index()
        {
            return View(Store.FetchAll<Contact>().AsContactBriefInfo());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Contact contact)
        {
            Store.Store<Contact>(contact);
            return RedirectToAction("Index");
        }
    }
}
