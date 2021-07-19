using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPTraining.Web.Models;
using System.Data.SqlClient;

namespace ASPTraining.Web.Controllers
{
    public class AccountController : Controller
    {
        //SqlConnection connection = new SqlConnection();
        //SqlCommand command = new SqlCommand();
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        void ConnectionString()
        {

        }
        public ActionResult Verify(Account account)
        {
            ConnectionString();
        
            return View();
        }
    }
}
