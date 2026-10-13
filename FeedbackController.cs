using System.Web.Mvc;
using practical_7.Models;

namespace practical_7.Controllers
{
    public class FeedbackController : Controller
    {
        // Display the feedback form
        public ActionResult Index()
        {
            return View(new Feedback());
        }

        // Submit feedback
        [HttpPost]
        public ActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Feedback submitted successfully!";
            }

            return View(feedback);
        }
    }
}
