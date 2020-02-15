using EmployeeMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace EmployeeMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public async Task<ActionResult> Index()
        {
            using (HttpResponseMessage response = await APIHelper.client.GetAsync("api/Employees"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var empList = response.Content.ReadAsAsync<IEnumerable<Employee>>().Result;
                    return View(empList);
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }

            }
        }




        // GET: Employee/Details/5
        public async Task<ActionResult> Details(int id)
        {
            using (HttpResponseMessage response = await APIHelper.client.GetAsync("api/Employees/" + id.ToString()))
            {
                if (response.IsSuccessStatusCode)
                {
                    var empList = response.Content.ReadAsAsync<IEnumerable<Employee>>().Result;
                    return View(empList);
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }

            }

        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public async Task<ActionResult> Create(Employee emp)
        {
            using (HttpResponseMessage response = await APIHelper.client.PostAsJsonAsync("api/Employees",emp))
            {
                if (response.IsSuccessStatusCode)
                {
                     
                    return View();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }

            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
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

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
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
