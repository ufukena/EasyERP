using EasyERP.Domain.Services.Models.Customers;
using EasyERP.UI.Infrastructure;
using EasyERP.Utils.Common;
using Microsoft.AspNetCore.Components;

namespace EasyERP.UI.Components.Pages.Customers
{
    public class CustomersModalBase : MainComponentBase
    {
        [Parameter] public EventCallback<bool> LoadData { get; set; }

        [Parameter] public bool IsVisible { get; set; } = true;
        [Parameter] public EventCallback<bool> Save { get; set; }

        
        public Customer customer;


        protected override async Task OnInitializedAsync()
        {
            customer = new Customer();
        }

        public void HandleValidSubmit()
        {
            AppManager.PageRender = true;
            LoadData.InvokeAsync();
            //IsVisible = false;
            //IsVisibleChanged.InvokeAsync(IsVisible);
        }

        public void Save2()
        {
            AppManager.PageRender = true;
            LoadData.InvokeAsync();
            IsVisible = false;            
        }

    }
}
