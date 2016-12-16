using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ConsultaProdutosWeb.Models;

namespace ConsultaProdutosWeb.Controllers
{
    public class ProductController : Controller
    {
        private ProductEntities db = new ProductEntities();

        // GET: Product
        public ActionResult Index()
        {
            return View(db.PRODUCTS.ToList());
        }

        // GET: Product/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUCTS pRODUCTS = db.PRODUCTS.Find(id);
            if (pRODUCTS == null)
            {
                return HttpNotFound();
            }
            return View(pRODUCTS);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PRODUCT_ID,NAME,DESCRIPTION,PRICE,CATEGORY")] PRODUCTS pRODUCTS)
        {
            if (ModelState.IsValid)
            {
                db.PRODUCTS.Add(pRODUCTS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pRODUCTS);
        }

        // GET: Product/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUCTS pRODUCTS = db.PRODUCTS.Find(id);
            if (pRODUCTS == null)
            {
                return HttpNotFound();
            }
            return View(pRODUCTS);
        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PRODUCT_ID,NAME,DESCRIPTION,PRICE,CATEGORY")] PRODUCTS pRODUCTS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRODUCTS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pRODUCTS);
        }

        // GET: Product/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUCTS pRODUCTS = db.PRODUCTS.Find(id);
            if (pRODUCTS == null)
            {
                return HttpNotFound();
            }
            return View(pRODUCTS);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            PRODUCTS pRODUCTS = db.PRODUCTS.Find(id);
            db.PRODUCTS.Remove(pRODUCTS);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
