using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
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
        public ActionResult User(string id)
        {
            //System.Diagnostics.Debug.WriteLine(id);
            if (id == "shudown")
            { }
            if (id == "reset")
            { }
            if(id == "sendimage")
            { }
            if(id == "null")
            { }
            PBL4Entities db = new PBL4Entities();
            //Console.WriteLine(id);
            return View(db.Users.ToList());
        }
        public ActionResult Data_Mode()
        {
            PBL4Entities db = new PBL4Entities();
            return View(db.Users.ToList());
        }
        public ActionResult Data1()
        {
            PBL4Entities db = new PBL4Entities();
            return View(db.Folders.ToList());
        }
        public ActionResult Image_View(string id)
        {
            System.Diagnostics.Debug.WriteLine(id);
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
        public ActionResult Change_Folder(string id)
        {
            PBL4Entities db = new PBL4Entities();
            List<Folder> result = new List<Folder>();
            result = db.Folders.Where(p => p.Type == "image" && p.UserID == id).ToList();
            return View(result);
        }
        public ActionResult Change_Folder_txt(string id)
        {
            PBL4Entities db = new PBL4Entities();
            List<Folder> result = new List<Folder>();
            result = db.Folders.Where(p => p.Type == "txt" && p.UserID == id).ToList();
            return View(result);
        }
        
    }
}