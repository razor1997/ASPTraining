using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPTraining.Web
{
    public class LoginPageModel : Controller
    {
        public void OnGet()
        {
        }
        public ActionResult LoginToSite()
        {
            return View("Index");
        }
    }
}
