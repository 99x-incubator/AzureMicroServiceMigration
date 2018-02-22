using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using DocumentImportService.Models;
using System.Collections.Generic;
using Dapper;
using System.Linq;

namespace DocumentImportService.Controllers
{
    [Route("api/[controller]")]
    public class InvoiceController : Controller
    {
        private readonly SqlConnection connection;

        public InvoiceController()
        {
            connection = DocumentImportDBConnectionFactory.Get();
        }

        [HttpGet]
        public IEnumerable<Invoice> Get()
        {
            return connection.Query<Invoice>("Select * FROM Invoices").ToList();
            //return new[] { "va;ue1", "value2" };
        }
    }
}