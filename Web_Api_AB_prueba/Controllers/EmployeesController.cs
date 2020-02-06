using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Web_Api_AB_prueba.Models;

namespace Web_Api_AB_prueba.Controllers
{
    public class EmployeesController : ApiController
    {
        private Prueba_ab_pos_solutions_josueromeroEntities db = new Prueba_ab_pos_solutions_josueromeroEntities();

        // GET: api/Employees
        public List<ClaseReporte> GetEmployees()
        {
            var Empleados = db.Employees.ToList();
            var ListaEspecifica = (from e in Empleados select new ClaseReporte()
            { ID= e.EmployeeID,Name = e.EmployeeName,PositionName = e.Position.PositionName, ProfileName = e.Profile.ProfileName }).ToList();

            return ListaEspecifica;
        }

       

       
    }
}