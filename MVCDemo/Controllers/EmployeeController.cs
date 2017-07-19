using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BussinessLayer;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        [HttpGet]
        [ActionName("Index")]
        public ActionResult Index_Post(/*string name*/)

        {
            
            EmployeeBussinessLayer employeeBussinessLayer = new EmployeeBussinessLayer();

            List<Employee> employee = employeeBussinessLayer.Employee.ToList();

            var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            string outputOfEnum = serializer.Serialize(employee);
            ViewBag.JsonSource = outputOfEnum;
            return View(employee);
        }
        [HttpPost]
        [ActionName("Index")]
        public ActionResult Index_Get(string searchBy, string search)

        {
           // if (searchBy == )

            return View();
            
        }


        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get()
        {


            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post(/*string AceId, string Name, string Email, string Mobile, string Steam*/)
        {
            if (ModelState.IsValid)
            {
               
                Employee employee = new Employee();

                //employee.AceId = AceId;
                //employee.Name = Name;
                //employee.Email = Email;
                //employee.Mobile = Mobile;
                //employee.Steam = Steam;


                UpdateModel(employee);


                EmployeeBussinessLayer employeeBussinessLayer = new EmployeeBussinessLayer();
            
                employeeBussinessLayer.AddEmployee(employee);

                return RedirectToAction("Index");
            }

            return View();
        }


        [HttpGet]
        [ActionName("Edit")]
        public ActionResult Edit_Get(int id)
        {
            EmployeeBussinessLayer employeeBussinessLayer = new EmployeeBussinessLayer();

            Employee employee = employeeBussinessLayer.Employee.Single(emp => emp.Id == id);

            return View(employee);
        }


        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post(Employee employee)
        {
            if (ModelState.IsValid)
            {

                EmployeeBussinessLayer employeeBussinessLayer = new EmployeeBussinessLayer();

                employeeBussinessLayer.SaveEmployee(employee);

                return RedirectToAction("Index");

            }




            return View(employee);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult delete(int id)
        {

            EmployeeBussinessLayer employeeBussinessLayer = new EmployeeBussinessLayer();

            employeeBussinessLayer.DeleteEmployee(id);


            return RedirectToAction("Index");
        }

        //[HttpGet]
        //[ActionName("Login")]
        //public ActionResult Login_Get()
        //{


        //    return View();
        //}



        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //[ActionName("Login")]
        //public ActionResult Login_Post(Users u)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        using ()
        //    }

        //    return View();

        //}
        //[ActionName("Index")]
        
    }
}