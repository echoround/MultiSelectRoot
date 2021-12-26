using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SelectBoxDomain.Models;
using SelectBoxAPI.Interfaces;

namespace SelectBoxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // Use Customer GUID to check if customer has filled form before and returns their ID if they have.
        // The customer GUID (customerauth) property is to emulate user credentials and have a unique user with forms per "session".
        // I did this to have a specific customer to get when repopulating the form for editing.
        // Not primary key because GUID is bad for indexing.

        // GET: api/Customers/db78ba89-b85f

        [HttpGet("{customerAuth}")]
        public async Task<ActionResult<Customer>> GetCustomerByGUID(string customerAuth)
        {

            if (customerAuth != null)
            {
                var customer = await _unitOfWork.Customers.GetCustomerByGUIDAsync(customerAuth);

                if (customer == null)
                {
                    return new Customer(); ;
                }

                return Ok(customer);

            }
            else {

                return BadRequest();

            }
                     
        }

              
        [HttpPost]
        // POST: Customer
        public async Task<IActionResult> PostCustomer(Customer customer)
        {

            if(await _unitOfWork.Customers.PostCustomerAsync(customer))
            {
                return Ok(customer);
            }

            else { 
                return BadRequest(); 
            }

        }


    }
}
