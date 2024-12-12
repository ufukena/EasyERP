using EasyERP.UI.Infrastructure;
using Microsoft.AspNetCore.Components;

namespace EasyERP.UI.Components.Pages.Customers
{
    public class CustomersModalBase : MainComponentBase
    {
        [Parameter] public EventCallback<bool> LoadData { get; set; }

        [Parameter] public EventCallback<bool> IsModalFired { get; set; }

        
        public void Save()
        {
            
            LoadData.InvokeAsync();
            IsModalFired.InvokeAsync(true);
        }

    }
}
