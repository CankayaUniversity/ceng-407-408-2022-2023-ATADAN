using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AtadanWebPage.Controllers
{
    public class LoginController : Controller
    {
        AdminManager ad = new AdminManager(new EfAdminDal());
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin a) 
        {
            var admininfo = ad.AdminLogin(a);

            try
            {
                TempData["başarılı"] = "Bilgiler doğru";
                FormsAuthentication.SetAuthCookie(admininfo.AdminEmail, false);
                Session["AdminName"] = admininfo.AdminEmail;
                return RedirectToAction("Index", "Plantphoto");
            }
            catch (Exception ex)
            {
                TempData["hata"] = "Kullanıcı adı veya Şifre yanlış olabilir!";
                return RedirectToAction("Login");
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
    
}