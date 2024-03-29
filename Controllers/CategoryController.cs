﻿using IdeaSystem.Data;
using IdeaSystem.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IdeaSystem.Data.Common;
using System.Transactions;

namespace IdeaSystem.Controllers
{
    [Authorize(Roles = "Admin,Qa")]
    public class CategoryController : Controller
    {
        private ApplicationDbContext context;
        public CategoryController(ApplicationDbContext _context)
        {
            context = _context;
        }

        // GET: CategoryController
        [Route("/category")]
        public ActionResult Index()
        {
            var query = context.CategoryTable.Where(x => x.category_IsDelete == false).ToList();
            return View(query);
        }

        // GET: CategoryController/Details/5
        [Route("/category/details")]
        public ActionResult Details(string id)
        {
            var query = context.CategoryTable.FirstOrDefault(x => x.category_Id == id);
            return View(query);
        }

        // GET: CategoryController/Create
        [Route("/category/create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [Route("/category/create")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection)
        {
            try
            {

                string categoryName = collection["category_Name"];

                Category categoryCreate = new Category() { 
                    category_Id = Guid.NewGuid().ToString(),
                    category_Name = categoryName,
                    category_IsDelete = false
                };

                await context.CategoryTable.AddAsync(categoryCreate);
                await context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Edit/5
        [Route("/category/edit")]
        public ActionResult Edit(string id)
        {
            var query = context.CategoryTable.FirstOrDefault(x => x.category_Id == id);
            return View(query);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [Route("/category/edit")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(IFormCollection collection)
        {
            try
            {
                string categoryId = collection["category_Id"];
                string categoryName = collection["category_Name"];
                var query = context.CategoryTable.FirstOrDefault(x => x.category_Id == categoryId);

                if (query != null)
                {
                    query.category_Name = categoryName;
                    await context.SaveChangesAsync();
                }
                

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Delete/5
        [Route("/category/delete")]
        public ActionResult Delete(string id, string message = "")
        {
            var query = context.CategoryTable.FirstOrDefault(x => x.category_Id == id);

            ViewBag.Message = message;
            return View(query);
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [Route("/category/delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(string id, IFormCollection collection)
        {
            try
            {
                string categoryId = collection["category_Id"];
                //var query = context.CategoryTable.FirstOrDefault(x => x.category_Id == categoryId);
                var queryWithIdea = (from a in context.CategoryTable
                            join b in context.IdeaTable on a.category_Id equals b.idea_CategoryId
                            where a.category_Id == categoryId
                            select new { a }).ToList();

                if (queryWithIdea != null && queryWithIdea.GetEnumerator().MoveNext())
                {

                    string message = "You can't delete it, because it's using";

                    return RedirectToAction("Delete", "category", new { message = message , id = categoryId });
                }
                else
                {
                    var query = context.CategoryTable.FirstOrDefault(x => x.category_Id == categoryId);

                    if (query != null)
                    {
                        query.category_IsDelete = true;
                        await context.SaveChangesAsync();
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
