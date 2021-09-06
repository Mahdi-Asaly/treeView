using Mahdi_Abd_Asali.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mahdi_Abd_Asali.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            List<TreeViewNode> tree = getTreeView();
            ViewBag.Json = JsonConvert.SerializeObject(tree);
            return View();
        }

        [HttpPost]
        public ActionResult Index(int id, string newName)
        {
            using (DBModel _context = new DBModel())
            {
                var root = _context.CommodityRoots.Find(id);
                if (root != null)
                {
                    root.Name = newName;
                    _context.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }

        private List<TreeViewNode> getTreeView()
        {
            using (DBModel _context = new DBModel())
            {
                List<TreeViewNode> tree = new List<TreeViewNode>();
                int count = _context.CommodityChapters.Count();
                foreach (CommodityChapters chapter in _context.CommodityChapters)
                {
                    tree.Add(new TreeViewNode
                    {
                        id = chapter.Id,
                        parent = "#",
                        name = chapter.Name,
                        code = chapter.Code,
                        text= "(" + chapter.Code + ")" + chapter.Name
                    }) ;
                }
                foreach (CommodityRoots root in _context.CommodityRoots)
                {
                    tree.Add(new TreeViewNode 
                    {
                        id = root.Id , 
                        parent = root.CommodityChapterId.ToString(),
                        code =root.Code ,
                        name=root.Name,
                        text= "(" + root.Code + ")" + root.Name 
                    });
                }
                return tree;
            }
        }
    }
}