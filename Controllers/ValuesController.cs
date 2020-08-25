using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ValuesController : ApiController
    {

        List<Employee> emp = new List<Employee>();

        public ValuesController()
        {
            emp.Add(new Employee { Id=1,Name="ramya",Address="VIJ"});
            emp.Add(new Employee { Id = 2, Name = "SADINENI", Address = "HYD" });
            emp.Add(new Employee { Id = 3, Name = "XYZ", Address = "KMMM" });

        }
        // GET api/values
        public List<Employee> Get()
        {
            return emp;
        }

        // GET api/values/5
        public Employee Get(int id)
        {
            Employee employee = emp.Find(emp => emp.Id== id);
            return employee;
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public string Delete(int id)
        {
            Employee employee = emp.Find(emp => emp.Id == id);
            emp.Remove(employee);
            return "employee removed with id: " + id;

        }
    }
}
