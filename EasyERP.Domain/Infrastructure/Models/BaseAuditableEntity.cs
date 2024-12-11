
namespace EasyERP.Domain.Infrastructure.Models
{

    public abstract class BaseAuditableEntity : BaseEntity
    {
        
        public DateTime? CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }
        public Guid? ModifiedBy { get; set; }

        public DateTime? DeletedDate { get; set; }
        public Guid? DeletedBy { get; set; }

        public bool? DeletedFlg { get; set; }
        

    }
}
