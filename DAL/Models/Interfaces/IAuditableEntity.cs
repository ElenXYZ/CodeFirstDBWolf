using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Interfaces
{
    public class IAuditableEntity:IModel
    {
        DateTime CreatedDate { get; set; }
        DateTime? UpdateDate { get; set; }
    }
}
