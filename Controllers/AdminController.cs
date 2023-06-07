using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AtadanWebPage.Controllers
{
    [Authorize(Roles="Yetkili")]
    public class AdminController : Controller
    {
        AdminManager ad = new AdminManager(new EfAdminDal());
        // GET: Admin
        public ActionResult Index()
        {
            var adminvalues = ad.GetList();
            return View(adminvalues);
        }
        [HttpGet]
        public ActionResult AdminAdd() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminAdd(Admin admin) 
        {
            try
            {
                TempData["addadmin"] = "Yönetici Bilgileri Kaydedildi";
                ad.AdminAdd(admin);
                return RedirectToAction("AdminAdd");

            }
            catch (Exception ex)
            {
                TempData["addcontacterror"] = "Hata! Kayıt Yapılamadı";
                return RedirectToAction("AdminAdd");
            }
        }

        public ActionResult AdminDelete(int id)
        {
            var value = ad.GetById(id);
            ad.AdminDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AdminUpdate(int id)
        {
            var value = ad.GetById(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult AdminUpdate(Admin p)
        {
            ad.AdminUpdate(p);
            return RedirectToAction("Index");
        }
    }
}