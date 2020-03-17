using Microsoft.AspNetCore.Mvc;
using Inventory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Controllers
{
  public class CollectionsController : Controller
  {
    private readonly InventoryContext _db;

    public CollectionsController(InventoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Collection> model = _db.Collections.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Collection collection)
    {
      _db.Collections.Add(collection);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Collection thisCollection = _db.Collections.FirstOrDefault(collection => collection.CollectionId == id);
      return View(thisCollection);
    }
  }
}