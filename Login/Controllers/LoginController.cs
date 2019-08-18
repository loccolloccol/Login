using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Login.Models;
using Login.DLL;

namespace Login.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        //[ValidateAntiForgeryToken]        [HttpPost, ActionName("Login")]
        public ActionResult  Login()
        {
            this.Session["captial"] = DateTime.Now.ToString("HHmmss");   
            return this.View();
        }
        [HttpPost]
        public ActionResult Login(LogViewModel loggin)
        {
            //檢核model
            if (!this.ModelState.IsValid)
            {
                return this.View(loggin);
            }
            //判斷是否成功
            Loginlinq loginlinq = new Loginlinq();
            var isLogin = loginlinq.Act(loggin);
            if (!isLogin)
            {
                this.ModelState.AddModelError("loggin", "登入失敗");
                return this.View(loggin);
            }
           

            return View();
        }
    }
}