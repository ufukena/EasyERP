
using EasyERP.Domain.Infrastructure.Models;

namespace EasyERP.Domain.Services.Models.Customers
{
    public class Customer : BaseAuditableEntity
    {
        public string CustomerName { get; set; } = string.Empty;

        public string CustomerAddress { get; set; } = string.Empty;


    }
}
