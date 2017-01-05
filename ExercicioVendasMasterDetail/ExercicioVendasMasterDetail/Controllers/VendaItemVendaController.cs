using ExercicioVendasMasterDetail.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExercicioVendasMasterDetail.Controllers
{
    public class VendaItemVendaController : Controller
    {
        private VendasModel db = new VendasModel();

        public string NewVenda()
        {

            //ista todos os produtos disponíveis
            List<Cliente> ListaClientes = db.Cliente.OrderBy(o => o.Nome).ToList();
            List<Produto> ListaProdutos = db.Produto.OrderBy(o => o.Descricao).ToList();

            //var model = new VendaItemVendaModel();


            //var vENDA = db.VENDA.Include(v => v.Cliente);
            // return View();
            return "Teste <b>somentes</b>";

        }

        // GET: VendaItemVenda
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "Nome,Sobrenome")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                db.Cliente.Add(cliente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cliente);
        }


        // GET: VendaItemVenda/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VendaItemVenda/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult CreateCliente()
        {
            return View();
        }

 

        // POST: VendaItemVenda/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: VendaItemVenda/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VendaItemVenda/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: VendaItemVenda/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VendaItemVenda/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
