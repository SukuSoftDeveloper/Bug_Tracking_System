using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BugTrackingSystem.Models;


namespace BugTrackingSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Main()
        {

            return View();
        }
        public ActionResult Index()
        {
            BugTrackingSystemEntities1 db = new BugTrackingSystemEntities1();
            List<Bug> bugs = db.Bugs.ToList();
            return View(bugs);
        }

       //public  ActionResult Details(long id)
       // {
       //     BugTrackingSystemEntities1 db = new BugTrackingSystemEntities1();
       //     Bug p = db.Bugs.Where(temp => temp.BugID == id).FirstOrDefault();
       //     return View(p);
       // }
        public ActionResult Detail(long id )
        {
            BugTrackingSystemEntities1 db = new BugTrackingSystemEntities1();
            Bug p = db.Bugs.Where(temp => temp.BugID == id).FirstOrDefault();
            return View(p);
        }
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Bug b)
        {
            BugTrackingSystemEntities1 db = new BugTrackingSystemEntities1();
            db.Bugs.Add(b);
            db.SaveChanges();
            return View();
        }
        public ActionResult Update(long id )
        {
            BugTrackingSystemEntities1 db = new BugTrackingSystemEntities1();
            Bug extbug = db.Bugs.Where(temp => temp.BugID == id).FirstOrDefault();
            return View(extbug);
        }
        [HttpPost]
        public ActionResult Update(Bug b)
        {
            BugTrackingSystemEntities1 db = new BugTrackingSystemEntities1();
            Bug extbug = db.Bugs.Where(temp => temp.BugID == b.BugID).FirstOrDefault();
            extbug.Tracker = b.Tracker;
            extbug.Subject = b.Subject;
            extbug.Description = b.Description;
            extbug.Status = b.Status;
            extbug.StartDate = b.StartDate;
            extbug.Priority = b.Priority;
            extbug.DueDate = b.DueDate;
            extbug.Assignee = b.Assignee;
            extbug.EstimatedTime = b.EstimatedTime;
            extbug.PercentageDone = b.PercentageDone;
            db.SaveChanges();
            return View();
          
        }
        public ActionResult Delete(long id)
        {
            BugTrackingSystemEntities1 db = new BugTrackingSystemEntities1();
            Bug extbug = db.Bugs.Where(temp => temp.BugID == id).FirstOrDefault();
            return View(extbug);
        }
        [HttpPost]
        public ActionResult Delete(long id,Bug b)
        {
            BugTrackingSystemEntities1 db = new BugTrackingSystemEntities1();
            Bug extbug = db.Bugs.Where(temp => temp.BugID == id).FirstOrDefault();
            db.Bugs.Remove(extbug);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}