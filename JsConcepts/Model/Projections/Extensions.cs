using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Projections
{
    public static class Extensions
    {
        public static ContactBriefInfo AsContactBriefInfo(this Contact contact)
        {
            return new ContactBriefInfo { 
                Id = contact.Id,
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                Company = contact.Company
            };
        }

        public static IEnumerable<ContactBriefInfo> AsContactBriefInfo(this IEnumerable<Contact> contacts)
        {
            return contacts.Select(c => c.AsContactBriefInfo()).ToArray();
        }
    }
}
