using BookStore.Data;
using BookStore.Models;
using BookStore.ViewModel;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class CategoriesController : Controller
    {
        ApplicationDbContext context;
        public CategoriesController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var categories = context.Categories.ToList();
            return View(categories);
        }


        [HttpGet]

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CategoryVM categoryVM)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", categoryVM);
            }
            var category = new Category
            {
                Name = categoryVM.Name
            };
            context.Categories.Add(category);

            context.SaveChanges();
            return RedirectToAction("Index");
        }
    
    [HttpGet]
    public IActionResult Edit(int id)
		{
				var category = context.Categories.Find(id);
			if (category is null)
			{
				return NotFound();

			}
			var viewModel = new CategoryVM
			{
				Id = id,
				Name = category.Name

			};
			return View("Create", viewModel);

		}
    [HttpPost]
    public IActionResult Edit(CategoryVM categoryvm)
    {

			if (!ModelState.IsValid)
			{
				return View("Create", categoryvm);
			}
			var category = context.Categories.Find(categoryvm.Id);
        if (category is null)
        {
            return NotFound();

        }

        category.Name = categoryvm.Name;
			category.UpdatedOn = DateTime.Now;
			context.SaveChanges();
        return RedirectToAction("Index");
    }
        public IActionResult Details(int id)
        {

            var category= context.Categories.Find(id);
             if (category is null)
            {
                 return NotFound();
            }
			var viewModel = new CategoryVM
			{
				Id = category.Id,
				Name = category.Name,
                CreatedOn = category.CreatedOn
                ,
                UpdatedOn =category.UpdatedOn
			};
			return View(viewModel);
        }
		public IActionResult Delete( int id)
        {
            var category = context.Categories.Find(id);
            context.Categories.Remove(category); 
            context .SaveChanges();
            return RedirectToAction("Index"); 
        }


	}

}
