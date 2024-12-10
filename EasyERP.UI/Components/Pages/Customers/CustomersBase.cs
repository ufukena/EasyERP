using EasyERP.Contract.Services.Customers;
using EasyERP.Domain.Services.Models.Customers;
using Microsoft.AspNetCore.Components;


namespace EasyERP.UI.Components.Pages.Customers
{
    public class CustomersBase : ComponentBase
    {

        [Inject] ICustomerRepository customerRepository { get; set; }
        public IEnumerable<Customer> customers { get; set; }



        protected async override Task OnInitializedAsync()
        {
            try
            {
                await base.OnInitializedAsync();
                customers = await customerRepository.GetAll();

            }
            catch (Exception)
            {

                // NavigationManager.NavigateTo("/", true);
            }

        }

        //protected async override Task OnAfterRenderAsync(bool firstRender)
        //{
        //    if (firstRender)
        //    {
        //        if (PostService is not null && PostId is not null)
        //        {
        //            Guid postGuid = new Guid(PostId);

        //            PostVM = await PostService.GetPost(postGuid);
        //            ConfigureDisplayPost(PostVM);
        //            HeadingVM = PostVM.HeadingDTO;
        //            await InvokeAsync(StateHasChanged);
        //        }

        //        customers = await customerRepository.GetAll();
        //        await InvokeAsync(StateHasChanged);
        //    }

        //    await base.OnAfterRenderAsync(firstRender);
        //}


    }

}
