using EasyERP.Application.Http.Adapters;
using EasyERP.Domain.Services.Models.Customers;
using EasyERP.UI.Infrastructure;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace EasyERP.UI.Components.Pages.Customers
{
    public class CustomersBase : MainComponentBase
    {
        
        public List<Customer>? customers { get; set; } = new();
        //public bool isModalFired = true;


        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
               
                await LoadData();
                await InvokeAsync(StateHasChanged);
                
            }

            await base.OnAfterRenderAsync(firstRender);
        }

        protected async Task Delete(Customer customer)
        {
            await ServiceHttpBase.Customer.DeleteAsync(customer); 
            customers = await ServiceHttpBase.Customer.GetAllAsync();

        }

        protected async Task LoadData()
        {
            customers = await ServiceHttpBase.Customer.GetAllAsync();
        }


        
    }

}
