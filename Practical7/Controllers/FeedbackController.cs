using Practical7.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using Practical7.Models;

namespace Practical7.Controllers
{
    public class FeedbackController : Controller
    {
        private static List<Feedback> feedbackList = new List<Feedback>();

        public ActionResult Index()
        {
            return View(feedbackList);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                feedbackList.Add(feedback);
                return RedirectToAction("List");
            }

            return View(feedback);
        }

        public ActionResult List()
        {
            return View(feedbackList);
        }
    }
}