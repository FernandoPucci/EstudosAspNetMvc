using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ExercicioVendasMasterDetail.Models;

namespace ExercicioVendasMasterDetail.Controllers
{
    public class ItemVendasController : Controller
    {
        private VendasModel db = new VendasModel();

        // GET: ItemVendas
        public ActionResult Index()
        {
            var iTEM_VENDA = db.ITEM_VENDA.Include(i => i.Produto).Include(i => i.Venda);
            return View(iTEM_VENDA.ToList());
        }

        // GET: ItemVendas/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemVenda itemVenda = db.ITEM_VENDA.Find(id);
            if (itemVenda == null)
            {
                return HttpNotFound();
            }
            return View(itemVenda);
        }

        // GET: ItemVendas/Create
        public ActionResult Create()
        {
            ViewBag.IdProduto = new SelectList(db.Produto, "IdProduto", "Descricao");
            ViewBag.IdVenda = new SelectList(db.VENDA, "IdVenda", "IdVenda");
            return View();
        }

        // POST: ItemVendas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdItemVenda,IdVenda,IdProduto,Quantidade,Subtotal")] ItemVenda itemVenda)
        {
            if (ModelState.IsValid)
            {
                db.ITEM_VENDA.Add(itemVenda);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdProduto = new SelectList(db.Produto, "IdProduto", "Descricao", itemVenda.IdProduto);
            ViewBag.IdVenda = new SelectList(db.VENDA, "IdVenda", "IdVenda", itemVenda.IdVenda);
            return View(itemVenda);
        }

        // GET: ItemVendas/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemVenda itemVenda = db.ITEM_VENDA.Find(id);
            if (itemVenda == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdProduto = new SelectList(db.Produto, "IdProduto", "Descricao", itemVenda.IdProduto);
            ViewBag.IdVenda = new SelectList(db.VENDA, "IdVenda", "IdVenda", itemVenda.IdVenda);
            return View(itemVenda);
        }

        // POST: ItemVendas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdItemVenda,IdVenda,IdProduto,Quantidade,Subtotal")] ItemVenda itemVenda)
        {
            if (ModelState.IsValid)
            {
                db.Entry(itemVenda).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdProduto = new SelectList(db.Produto, "IdProduto", "Descricao", itemVenda.IdProduto);
            ViewBag.IdVenda = new SelectList(db.VENDA, "IdVenda", "IdVenda", itemVenda.IdVenda);
            return View(itemVenda);
        }

        // GET: ItemVendas/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemVenda itemVenda = db.ITEM_VENDA.Find(id);
            if (itemVenda == null)
            {
                return HttpNotFound();
            }
            return View(itemVenda);
        }

        // POST: ItemVendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            ItemVenda itemVenda = db.ITEM_VENDA.Find(id);
            db.ITEM_VENDA.Remove(itemVenda);
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
