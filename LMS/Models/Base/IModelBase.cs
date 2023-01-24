using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LMS.Models.Base
{
    interface IModelBase
    {
        int Id { get; set; }
        DateTimeOffset CreatedOn { get; set; }

        int? CreatedBy { get; set; }

        DateTimeOffset UpdatedOn { get; set; }  

        int? UpdatedBy { get; set; }

        
    }
}
