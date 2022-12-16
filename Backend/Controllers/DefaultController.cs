using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Pages
{
    public class DefaultController : Controller
    {
        // GET: DefaultController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DefaultController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DefaultController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DefaultController/Create
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

        // GET: DefaultController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DefaultController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public string Get()
        {

            {
                return "Aplicacion corriendo...";
            }

        }



    }
}
