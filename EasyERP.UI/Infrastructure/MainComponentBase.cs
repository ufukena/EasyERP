using EasyERP.Application.Http.Adapters;
using Microsoft.AspNetCore.Components;


namespace EasyERP.UI.Infrastructure
{
    public class MainComponentBase : ComponentBase
    {
        [Inject] public ServiceHttpBase ServiceHttpBase { get; set; }

    }
}
