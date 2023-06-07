using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using System.Web.UI.WebControls;

namespace AtadanWebPage.Controllers
{
    [Authorize]
    public class PlantphotoController : Controller
    {
        PlantphotoManager pm = new PlantphotoManager(new EfPlantphotoDal());
        // GET: Plantphoto
        public ActionResult Index(string p)
        {
            if (string.IsNullOrEmpty(p))
            {
                var plantphotovalues = pm.GetList();
                return View(plantphotovalues);
            }
            else
            {
                var values = pm.GetBySearchList(p);
                return View(values);
            }
        }
        [HttpGet]
        public ActionResult PlantphotoAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PlantphotoAdd( HttpPostedFileBase imageFile)
        {
            Plantphoto photo = new Plantphoto();
            if (imageFile != null && imageFile.ContentLength > 0)
            {
                photo.PlantphotoName = Path.GetFileName(imageFile.FileName);
                using (BinaryReader reader = new BinaryReader(imageFile.InputStream))
                {
                    photo.PlanphotoImage = reader.ReadBytes(imageFile.ContentLength);
                }
                photo.PlantphotoDate = DateTime.Now;
                pm.PlantphotoAdd(photo);
            }
            else
                return View();

            return RedirectToAction("Index");
        }
        public ActionResult GetImage(int id)
        {
            Plantphoto p = pm.GetById(id);
            if (p != null)
            {
                return File(p.PlanphotoImage, "image/jpeg");
            }
            else
            {
                return HttpNotFound();
            }
        }
        public ActionResult Download(int id)
        {
            Plantphoto p = pm.GetById(id);
            if (p != null)
            {
                string contentType = "image/jpeg";
                return File(p.PlanphotoImage, contentType, p.PlantphotoName);
            }
            else
            {
                return HttpNotFound();
            }
        }
        public ActionResult PhotoDelete(int id)
        {
            var value = pm.GetById(id);
            pm.PlantphotoDelete(value);
            return RedirectToAction("Index");
        }

    }
}