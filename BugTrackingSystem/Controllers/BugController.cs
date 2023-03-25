using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BugTrackingSystem.Models;


namespace BugTrackingSystem.Controllers
{
    public class BugController : Controller
    {
        // GET: Bug
        public ActionResult Index()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Index(Bug b)
        {
            BugTrackingSystemEntities1 db = new BugTrackingSystemEntities1();
            db.Bugs.Add(b);
            db.SaveChanges();
            return View();
        }
        public ActionResult Edit(long id)
        {
            BugTrackingSystemEntities1 db = new BugTrackingSystemEntities1();
            Bug existingbug = db.Bugs.Where(temp => temp.BugID == id).FirstOrDefault();
            return View(existingbug);
        }
        [HttpPost]
        public ActionResult Edit(Bug b)
        {
            BugTrackingSystemEntities1 db = new BugTrackingSystemEntities1();
            Bug existingbug = db.Bugs.Where(temp => temp.BugID ==b.BugID ).FirstOrDefault();
            existingbug.Tracker = b.Tracker;
            existingbug.Subject = b.Subject;
            existingbug.Description = b.Description;
            existingbug.Status = b.Status;
            existingbug.StartDate = b.StartDate;
            existingbug.Priority = b.Priority;
            existingbug.DueDate = b.DueDate;
            existingbug.Assignee = b.Assignee;
            existingbug.EstimatedTime = b.EstimatedTime;
            existingbug.PercentageDone= b.PercentageDone;
            return View();
        }
    }
}