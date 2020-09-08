using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MdSohail_GaggleChallenge.Data;
using MdSohail_GaggleChallenge.Models.Nhl;

namespace MdSohail_GaggleChallenge.Controllers
{
    public class ProductsController : Controller
    {
        private NhlContext db = new NhlContext();

        // GET: Products
        public ActionResult Index()
        {
            List<Product> product = new List<Product>();

            var data = db.Products.ToList();
            foreach(var item in data)
            {
                Product pr = new Product();
                pr.GUID = item.GUID;
                pr.ProductName = item.ProductName;
                pr.Description = item.Description;
                pr.CreatedDate = item.CreatedDate;
                pr.UpdatedDate = item.UpdatedDate;
                pr.Active = item.Active;
                product.Add(pr);    
            }

            return View(product);
        }

        // GET: Products/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }

            Product pr = new Product();

            pr.GUID = product.GUID;
            pr.ProductName = product.ProductName;
            pr.Description = product.Description;
            pr.CreatedDate = product.CreatedDate;
            pr.UpdatedDate = product.UpdatedDate;
            pr.Active = product.Active;

            return View(pr);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GUID,ProductName,Description,CreatedDate,UpdatedDate,Active")] Product product)
        {
            Product pr = new Product();
            Guid guid = Guid.NewGuid();

            if (ModelState.IsValid)
            {
                pr.GUID = guid.ToString();
                pr.ProductName = product.ProductName;
                pr.Description = product.Description;
                pr.CreatedDate = product.CreatedDate;
                pr.UpdatedDate = product.UpdatedDate;
                pr.Active = product.Active;
                
                db.Products.Add(pr);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pr);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Where(x => x.GUID == id).FirstOrDefault();
            if (product == null)
            {
                return HttpNotFound();
            }

            Product pr = new Product();

            pr.ProductName = product.ProductName;
            pr.GUID = product.GUID;
            pr.ProductName = product.ProductName;
            pr.Description = product.Description;
            pr.CreatedDate = product.CreatedDate;
            pr.UpdatedDate = product.UpdatedDate;
            pr.Active = product.Active;

            return View(pr);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GUID,ProductName,Description,CreatedDate,UpdatedDate,Active")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
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
