using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpactaLawTech.ToDo.Domain.Entities
{
    public  class UserTasks : EntityBase
    {
        public User User { get; set; }
        public Tasks Tasks { get; set; }
    }
}
