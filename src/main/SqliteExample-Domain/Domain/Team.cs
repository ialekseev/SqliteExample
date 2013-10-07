using System.Collections.Generic;

namespace SmartElk.SqliteExample.Domain.Domain
{
    public class Team: BaseEntity<int>
    {        
        public virtual string Name { get; set; }				
		public virtual string BusinessGroup { get; set; }
		public virtual IList<Employee> Members { get; set; }		
    }
}
