using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using View_PBL4.Models;

namespace View_PBL4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult User()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        public ActionResult Data()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        public ActionResult Image_View(string id)
        {   
            PBL4Entities db = new PBL4Entities();
            List<FileDetail> result = new List<FileDetail>();
            result = db.FileDetails.Where(p => p.FolderID == id).ToList();
            return View(result);
        }
        public ActionResult Text_View(string id)
        {
            PBL4Entities db = new PBL4Entities();
            List<FileDetail> result = new List<FileDetail>();
            result = db.FileDetails.Where(p => p.FolderID == id).ToList();
            return View(result);
        }
        public ActionResult Change_Folder()
        {
            PBL4Entities db = new PBL4Entities();
            List<Folder> result = new List<Folder>();
            result = db.Folders.Where(p => p.Type == "image").ToList();
            return View(result);
        }
        public ActionResult Change_Folder_txt()
        {
            PBL4Entities db = new PBL4Entities();
            List<Folder> result = new List<Folder>();
            result = db.Folders.Where(p => p.Type == "txt").ToList();
            return View(result);
        }
    }
}