using EasyERP.Application.Adapters;
using Microsoft.AspNetCore.Mvc;


namespace EasyERP.Api.Infrastructure
{
    public class MainControllerBase : ControllerBase
    {

        public ServiceBase ServiceBase { get; set; }

    }

}
