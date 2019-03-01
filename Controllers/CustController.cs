using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCDatabaseApp.Models;

namespace MVCDatabaseApp.Controllers
{
    public class CustController : Controller
    {
        private CustomerContext db = new CustomerContext();

        // GET: /Cust/
        public ActionResult Index()
        {
            return View(db.Customers.ToList());
        }

        // GET: /Cust/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer1 customer1 = db.Customers.Find(id);
            if (customer1 == null)
            {
                return HttpNotFound();
            }
            return View(customer1);
        }

        // GET: /Cust/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Cust/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Customer1Id,name,address,email,username,pwd")] Customer1 customer1)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customer1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customer1);
        }

        // GET: /Cust/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer1 customer1 = db.Customers.Find(id);
            if (customer1 == null)
            {
                return HttpNotFound();
            }
            return View(customer1);
        }

        // POST: /Cust/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Customer1Id,name,address,email,username,pwd")] Customer1 customer1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer1);
        }

        // GET: /Cust/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer1 customer1 = db.Customers.Find(id);
            if (customer1 == null)
            {
                return HttpNotFound();
            }
            return View(customer1);
        }

        // POST: /Cust/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customer1 customer1 = db.Customers.Find(id);
            db.Customers.Remove(customer1);
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
