﻿using DevXuongMoc.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevXuongMoc.Controllers
{
    public class CategoryController : Controller
    {
        private readonly DevXuongMocContext _dataContext;

        public CategoryController(DevXuongMocContext context)
        { 
            _dataContext = context;
        }
        public async Task<IActionResult> Index(string Slug="")
        {
            //Category category = _dataContext.Categories.Where(c => c.Slug == Slug).FirstOrDefault();
            //if (category == null) return RedirectToAction("Index"); 
            //var productsByCategory = _dataContext.Products.Where(c=>c.CategoryId == category.Id);
            //return View(await productsByCategory.OrderByDescending(c=>c.Id).ToListAsync());
            return View();
        }
    }
}