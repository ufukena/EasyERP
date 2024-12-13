using EasyERP.Application.Http.Adapters;
using EasyERP.Utils.Common;
using Microsoft.AspNetCore.Components;


namespace EasyERP.UI.Infrastructure
{
    public class MainComponentBase : ComponentBase
    {
        [Inject] public ServiceHttpBase ServiceHttpBase { get; set; }

        [Inject] public AppManager AppManager { get; set; }

    }
}
