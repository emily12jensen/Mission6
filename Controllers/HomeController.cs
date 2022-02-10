using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mission6.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mission6.Controllers
{
    public class HomeController : Controller
    {

        private TaskInputContext _taskContext { get; set; }

        public HomeController( TaskInputContext context)
        {
            _taskContext = context;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Confirmation()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Quadrant()
        {
            var taskList = _taskContext.responses
                .Include(x => x.Category)
                .Where(x => x.Completed == false)
                .ToList();
            return View(taskList);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Categories = _taskContext.Category.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Add(TaskInput newTask)
        {
            if (ModelState.IsValid)
            {
                _taskContext.Add(newTask);
                _taskContext.SaveChanges();
                return View("Confirmation", newTask);

            }
            else
            {
                ViewBag.Categories = _taskContext.Category.ToList();
                return View(newTask);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = _taskContext.Category.ToList();
            var task = _taskContext.responses.Single(x => x.TaskID == id);
            return View("Edit", task);
        }
        [HttpPost]
        public IActionResult Edit(TaskInput editedTask)
        {

            _taskContext.Update(editedTask);
            _taskContext.SaveChanges();
            return RedirectToAction("Quadrant");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var quadrant = _taskContext.responses.Single(x => x.TaskID == id);
            return View(quadrant);
        }

        [HttpPost]
        public IActionResult Delete(TaskInput deleteTask)
        {
            _taskContext.responses.Remove(deleteTask);
            _taskContext.SaveChanges();
            return RedirectToAction("Quadrant");
        }
    }
}
