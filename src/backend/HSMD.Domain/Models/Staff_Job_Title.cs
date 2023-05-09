using HSMD.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Domain.Models
{
    public class Staff_Job_Title : AuditableBaseEntity
    {
        public int Staff_Job_Title_Id { get; set; }
        public int Staff_ID { get; set; }
        public int Job_Title_Code { get; set; }

    }
}
