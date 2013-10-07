using System.Collections.Generic;

namespace SmartElk.SqliteExample.Domain.Domain
{
    public class Employee: BaseEntity<string>
    {        
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }        
        public virtual string Email { get; set; }
        public virtual string JobTitle { get; set; }
        public virtual Employee LineManager { get; set; }
        public virtual IList<Team> Teams { get; set; }
    }
}
