using EasyERP.Application.Adapters;
using Microsoft.AspNetCore.Mvc;


namespace EasyERP.Api.Controllers.Service
{
    [Route("customers")]
    [ApiController]

    public class CustomersController : ControllerBase
    {

        private readonly ServiceBase serviceBase;

        public CustomersController(ServiceBase _serviceBase)
        {
            serviceBase = _serviceBase;
        }



        [Route("get/{id}")]
        [HttpPost]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await serviceBase.CustomerRepository.Get(id);
            return Ok(result);
        }

    }
}
