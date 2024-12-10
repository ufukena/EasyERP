using EasyERP.Application.Adapters;
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


    }
}
