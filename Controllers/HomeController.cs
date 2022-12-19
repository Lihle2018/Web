using Microsoft.AspNetCore.Mvc;
using Web.Models;
using Web.Services;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private EmailService _emailService;
        private FirebaseService _firebaseService;
        
        public HomeController(EmailService emailService,FirebaseService firebaseService)
        {
            _emailService = emailService;
            _firebaseService = firebaseService;
        }
        public IActionResult Index()
        {
            ViewData["ActionMethod"] = "Index";
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Courses()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            ViewData["ActionMethod"] = "ContactUs";
            return View();
        }
        public async Task<IActionResult> Contact(Contact contact,string ReturnUrl)
        {
            var path = HttpContext.Session.GetString("ReturnUrl");
            if (ModelState.IsValid)
            {
                var Subject =contact.Name+" " +contact.CourseType+" " + contact.Code;
                await _emailService.SendEmail(contact.Email, "2018293130@ufs4life.ac.za", Subject, contact.Message);
                await _firebaseService.SaveMessage(contact);
                return RedirectToAction(ReturnUrl);
                 
            }
            else
            {
                return RedirectToAction(ReturnUrl); 
            }
            
        }
    }
}
