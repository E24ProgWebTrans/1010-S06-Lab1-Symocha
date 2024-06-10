using Microsoft.AspNetCore.Mvc;
using ZombieParty.Models;
using ZombieParty.Models.Data;

namespace ZombieParty.Controllers
{
    public class HuntingLogController : Controller
    {
        private ZombiePartyDbContext _baseDonnees { get; set; }

        public HuntingLogController(ZombiePartyDbContext baseDonnees)
        {
            _baseDonnees = baseDonnees;
        }

        public IActionResult Index()
        {
            return View(_baseDonnees.HuntingLogs.ToList());
        }

        //GET
        public IActionResult Upsert(int? id)
        {
            if (id == null || id == 0)
                // create
                return View(new HuntingLog());
            else
                //update
                return View(_baseDonnees.HuntingLogs.Find(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(HuntingLog huntingLog)
        {
            if (ModelState.IsValid)
            {
                // Create
                if (huntingLog.Id == 0)
                {
                    // Ajouter à la BD
                    _baseDonnees.HuntingLogs.Add(huntingLog);
                    TempData["Success"] = $"{huntingLog.Title} hunting log added";
                }
                else
                {
                    // Update
                    _baseDonnees.HuntingLogs.Update(huntingLog);
                    TempData["success"] = $"{huntingLog.Title} hunting log updated";
                }
                _baseDonnees.SaveChanges();

                return this.RedirectToAction("Index");
            }

            return this.View(huntingLog);
        }
    }
}
