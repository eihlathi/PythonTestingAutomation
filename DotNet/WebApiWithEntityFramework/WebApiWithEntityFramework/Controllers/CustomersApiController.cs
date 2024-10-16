using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiWithEntityFramework.Models;

namespace WebApiWithEntityFramework.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomersApiController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public List<Customer> GetCustomers()
        {
            NorthwindContext context = new();
            List<Customer> allCustomers = [..context.Customers];

            return allCustomers;
        }
    }
}
