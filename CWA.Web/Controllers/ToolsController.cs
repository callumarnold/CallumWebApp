using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CWA.Library;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CWA.Web.Controllers
{
    public class ToolsController : Controller
    {
        private StringTools _stringTools;
        public ToolsController()
        {
            _stringTools = new StringTools();
        }
        // GET: ToolsController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Help()
        {
            return View();
        }

        [HttpPost("{input}")]
        public ActionResult Palindrome(string input)
        {
            string result;
            if(_stringTools.IsPalindrome(input))
            {
                result = $"Yes, {input} is a palindrome.";
            }
            else
            {
                result = $"No, {input} is not a palindrome.";
            }

            ViewData["IsPalindromeResult"] = result;
            return View();
        }

        // GET: ToolsController/Details/5
        
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ToolsController/Create
        public ActionResult Create()
        {
            return View();
        }

        //// POST: ToolsController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: ToolsController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: ToolsController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: ToolsController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: ToolsController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
