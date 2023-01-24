using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.Models.Base
{
    public class ModelBase : IModelBase
    {
        public int Id { get ; set; }
        public DateTimeOffset CreatedOn { get; set; }

        [Required]
        public int? CreatedBy { get; set; }
        [ForeignKey(nameof(CreatedBy))]
        public virtual UserMaster? CreatedByUser { get; set; }

        public DateTimeOffset UpdatedOn { get; set; }

        [Required]  
        public int? UpdatedBy { get; set ; }
        [ForeignKey(nameof(UpdatedBy))]
        public virtual UserMaster? UpdatedByUser { get; set; }
       
    }
}
