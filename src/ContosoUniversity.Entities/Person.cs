using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUniversity.Entities
{
    public abstract class Person : BaseEntity<int>
    {
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        } 
    }
}
