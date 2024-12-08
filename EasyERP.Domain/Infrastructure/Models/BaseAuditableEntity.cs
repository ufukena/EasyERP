
namespace EasyERP.Domain.Infrastructure.Models
{

    public abstract class BaseAuditableEntity : BaseEntity
    {
        
        public DateTime? CreatedDate { get; set; }
        public int CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public DateTime? DeletedDate { get; set; }
        public int? DeletedBy { get; set; }

        public bool? DeletedFlg { get; set; }
        

    }
}
