using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjetoVendasWeb.Models;

namespace ProjetoVendasWeb.Controllers
{
    public class ProdutoController : Controller
    {
        private DdEntities db = new DdEntities();

        // GET: Produto
        public ActionResult Index()
        {
            var produtos = db.produtos.Include(p => p.fornecedor);
            return View(produtos.ToList());
        }

        // GET: Produto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = db.produtos.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            ViewBag.COD_FORNECEDOR = new SelectList(db.fornecedor, "COD_FORNECEDOR", "NOME_FORNECEDOR");
            return View();
        }

        // POST: Produto/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "COD_PRODUTO,COD_FORNECEDOR,NOME_PRODUTO,PRECO_UNITARIO")] Produto produto)
        {
            if (ModelState.IsValid)
            {
                db.produtos.Add(produto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.COD_FORNECEDOR = new SelectList(db.fornecedor, "COD_FORNECEDOR", "NOME_FORNECEDOR", produto.COD_FORNECEDOR);
            return View(produto);
        }

        // GET: Produto/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = db.produtos.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            ViewBag.COD_FORNECEDOR = new SelectList(db.fornecedor, "COD_FORNECEDOR", "NOME_FORNECEDOR", produto.COD_FORNECEDOR);
            return View(produto);
        }

        // POST: Produto/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "COD_PRODUTO,COD_FORNECEDOR,NOME_PRODUTO,PRECO_UNITARIO")] Produto produto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(produto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.COD_FORNECEDOR = new SelectList(db.fornecedor, "COD_FORNECEDOR", "NOME_FORNECEDOR", produto.COD_FORNECEDOR);
            return View(produto);
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = db.produtos.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // POST: Produto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Produto produto = db.produtos.Find(id);
            db.produtos.Remove(produto);
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
