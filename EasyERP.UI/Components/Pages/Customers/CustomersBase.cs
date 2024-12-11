using EasyERP.Contract.Services.Customers;
using EasyERP.Domain.Services.Models.Customers;
using Microsoft.AspNetCore.Components;


namespace EasyERP.UI.Components.Pages.Customers
{
    public class CustomersBase : ComponentBase
    {

        [Inject] ICustomerRepository customerRepository { get; set; }
        public List<Customer>? customers { get; set; } = new();



        //protected async override Task OnInitializedAsync()
        //{
        //    try
        //    {                
        //        customers = await customerRepository.GetAllList();
        //    }
        //    catch (Exception)
        //    {

        //        // NavigationManager.NavigateTo("/", true);
        //    }

        //}

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {                
                customers = await customerRepository.GetAll();
                await InvokeAsync(StateHasChanged);
            }

            await base.OnAfterRenderAsync(firstRender);
        }

        protected async Task Delete(Customer customer)
        {
            await customerRepository.Delete(customer);
            customers = await customerRepository.GetAll();
        }



    }

}
