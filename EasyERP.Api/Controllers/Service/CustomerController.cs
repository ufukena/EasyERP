using EasyERP.Api.Infrastructure;
using EasyERP.Application.Adapters;
using EasyERP.Domain.Services.Models.Customers;
using Microsoft.AspNetCore.Mvc;


namespace EasyERP.Api.Controllers.Service
{
    [Route("customer")]
    [ApiController]

    public class CustomerController : MainControllerBase
    {

        private readonly ServiceBase ServiceBase;


        public CustomerController(ServiceBase _serviceBase)
        {
            ServiceBase = _serviceBase;
        }



        [Route("get/{id}")]
        [HttpGet]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await ServiceBase.Customer.GetAsync(id);
            return Ok(result);
        }


        [Route("getall")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await ServiceBase.Customer.GetAllAsync();
            return Ok(result);
        }

        [Route("delete")]
        [HttpPost]
        public async Task<IActionResult> Delete([FromBody] Customer customer)
        {
            await ServiceBase.Customer.DeleteAsync(customer);
            return Ok();
        }

      

    }
}
