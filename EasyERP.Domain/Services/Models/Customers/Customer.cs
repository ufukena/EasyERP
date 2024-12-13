
using EasyERP.Domain.Infrastructure.Models;
using System.ComponentModel.DataAnnotations;

namespace EasyERP.Domain.Services.Models.Customers
{
    public class Customer : BaseAuditableEntity
    {
        public string CustomerName { get; set; } = string.Empty;


        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi girin.")]
        public string CustomerAddress { get; set; } = string.Empty;


    }
}
