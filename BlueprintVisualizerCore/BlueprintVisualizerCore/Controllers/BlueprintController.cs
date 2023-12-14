using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlueprintVisualizerCore.Controllers
{
    public class BlueprintController : Controller
    {
        // GET: BlueprintController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BlueprintController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BlueprintController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlueprintController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BlueprintController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BlueprintController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BlueprintController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BlueprintController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
