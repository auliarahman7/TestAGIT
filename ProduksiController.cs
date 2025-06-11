using System;
using System.Linq;
using System.Web.Mvc;

public class ProduksiController : Controller
{
    private ApplicationDbContext db = new ApplicationDbContext();

    public ActionResult Index()
    {
        var lastData = db.ProduksiMobils
                         .OrderByDescending(p => p.TanggalInput)
                         .FirstOrDefault();
        return View(lastData ?? new ProduksiMobil());
    }

    [HttpPost]
    public ActionResult Simpan(ProduksiMobil model)
    {
        if (ModelState.IsValid)
        {
            db.ProduksiMobils.Add(model);
            db.SaveChanges();
        }

        return RedirectToAction("Index");
    }
}
 