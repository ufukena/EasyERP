using EasyERP.Application.Adapters;
using EasyERP.Domain.Services.Models.Customers;
using Microsoft.AspNetCore.Mvc;


namespace EasyERP.Api.Controllers.Service
{
    [Route("customer")]
    [ApiController]

    public class CustomerController : ControllerBase
    {

        private readonly ServiceBase serviceBase;

        public CustomerController(ServiceBase _serviceBase)
        {
            serviceBase = _serviceBase;
        }



        [Route("get/{id}")]
        [HttpGet]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await serviceBase.CustomerRepository.Get(id);
            return Ok(result);
        }


        [Route("getall")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await serviceBase.CustomerRepository.GetAll();
            return Ok(result);
        }

        [Route("delete")]
        [HttpPost]
        public async Task<IActionResult> Delete([FromBody] Customer customer)
        {
            await serviceBase.CustomerRepository.Delete(customer);
            return Ok();
        }

      

    }
}
