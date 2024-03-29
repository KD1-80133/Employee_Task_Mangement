﻿using EnitityModelLib;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RepositoryLib;


namespace WebAPI.Controllers
{
    [Route("/Department")]
    [ApiController]
    [Authorize]
    public class DepartMentController : ControllerBase
    {
        DepartmentRepository service;
        public DepartMentController()
        {
            service = new DepartmentRepository();
        }
        // GET: api/<DepartMentController>
        /* [HttpGet]
         public IEnumerable<string> Get()
         {
             return new string[] { "value1", "value2" };
         }*/

        [HttpGet("{id}")]
        public Department GetById(int id)
        {

            return service.FindById(id);

        }
        //GET ALL DEPARTMENTS
        [HttpGet]
        [Route("")]
        public IEnumerable<Department> Get()
        {
            return service.GetDepartments();

        }


        // POST api/<DepartMentController>
        [HttpPost]
        [Route("Add")]
        public void Post([FromBody] Department value)
        {
            service.Add(value);
        }

        // PUT api/<DepartMentController>/5
        /*[HttpPut]
        [Route("Modify")]
        public void Put([FromBody] Department value)
        {

           service.Modify(value);
       }*/

        [HttpPut]
        [Route("Modify")]
        public void Put(int id, [FromBody] Department value)
        {
            Department tomodified = service.FindById(id);
            Console.WriteLine(tomodified);
            tomodified.DeptId = id;
            tomodified.DeptName = value.DeptName;
            Console.WriteLine(tomodified);
            service.Modify(tomodified);
        }

        // DELETE api/<DepartMentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.Remove(id);
        }


        /*[HttpDelete]
         public void Delete(Department department)
        {
            service.Remove(department);
        }*/

    }
}