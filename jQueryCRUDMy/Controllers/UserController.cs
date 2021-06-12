using System.Data.Entity;
using jQueryCRUDMy.Context;
using System.Linq;
using System.Web.Mvc;


namespace jQueryCRUDMy.Controllers {
    public class UserController : Controller {
        private readonly DataContext _db = new DataContext();

        // GET: User
        public ActionResult Index() {
            return View(_db.User.ToList());
        }

        //
        // GET: /User/Details/5

        public ActionResult Details(int id = 0) {
            User user = _db.User.Find(id);
            if (user == null) {
                return HttpNotFound();
            }
            return PartialView(user);
        }

        //
        // GET: /User/Create

        public ActionResult Create() {
            return PartialView();
        }

        //
        // POST: /User/Create

        [HttpPost]
        public ActionResult Create(User user) {
            if (ModelState.IsValid) {
                _db.User.Add(user);
                _db.SaveChanges();
                TempData["Message"] = "Data has been saved successfully!";
                return RedirectToAction("Index");
            }

            return View(user);
        }

        //
        // GET: /User/Edit/5

        public ActionResult Edit(int id = 0) {
            User user = _db.User.Find(id);
            if (user == null) {
                return HttpNotFound();
            }
            return PartialView(user);
        }

        //
        // POST: /User/Edit/5

        [HttpPost]
        public ActionResult Edit(User user) {
            if (ModelState.IsValid) {
                _db.Entry(user).State = EntityState.Modified;
                _db.SaveChanges();
                TempData["Message"] = "Data has been updated successfully!";
                return RedirectToAction("Index");
            }
            return View(user);
        }

        //
        // GET: /User/Delete/5

        public ActionResult Delete(int id = 0) {
            User user = _db.User.Find(id);
            _db.User.Remove(user);
            _db.SaveChanges();
            TempData["Message"] = "Data has been deleted successfully!";
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing) {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}