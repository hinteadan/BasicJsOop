using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Projections;

namespace Model.Projections
{
    public class ContactBriefInfo
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
    }
}
