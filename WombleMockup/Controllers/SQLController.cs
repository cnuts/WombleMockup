using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace WombleMockup.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SQLController : ControllerBase
    {
        public readonly IConfiguration configuration;

        //CORE uses dependency injection - you need to inject 'outside' depedencies
        //Normally you would inject a Dbcontext and use entity framework but you can do as you wish.

        public SQLController(IConfiguration config)
        {
            this.configuration = config;
        }
        public IActionResult CallDb()
        {
            var connectionString = configuration.GetConnectionString("TEDS");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var procName = "YourProcNameInTheDB";
                ///Note: Have parameters?  add a parameters collection here

                using (SqlCommand cmd = new SqlCommand(procName, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    //cmd.Parameters = new SqlParameterCollection();
                    var ret = cmd.ExecuteScalar();
                    
                    connection.Close();
                }
            }

            return Ok("Send the results back");
        }
    }
}
