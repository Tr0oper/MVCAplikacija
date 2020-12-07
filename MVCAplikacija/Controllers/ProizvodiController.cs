using MVCAplikacija.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAplikacija.Controllers
{
    public class ProizvodiController : Controller
    {
        BazaProizvoda _context = new BazaProizvoda();

        // GET: Proizvodi
        public ActionResult Index()
        {
            return View(_context.Proizvodis.ToList());
        }

        // GET: Proizvodi/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Proizvodi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Proizvodi/Create
        [HttpPost]
        public ActionResult Create(Proizvodi proizvod)
        {
            try
            {
                _context.Proizvodis.Add(proizvod);
                _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Proizvodi/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_context.Proizvodis.Where(p=>p.ID == id).FirstOrDefault());
        }

        // POST: Proizvodi/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Proizvodi proizvodZaIzmenu)
        {
            try
            {
                var proizvodIzBaze = _context.Proizvodis.Where(p => p.ID == proizvodZaIzmenu.ID).FirstOrDefault();

                _context.Entry(proizvodIzBaze).CurrentValues.SetValues(proizvodZaIzmenu);
                _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //// GET: Proizvodi/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Proizvodi/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
