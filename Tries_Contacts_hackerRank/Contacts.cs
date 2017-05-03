using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tries_Contacts_hackerRank
{
  public  class Contacts
    {
        Dictionary<string, string> contacts = new Dictionary<string, string>();

        internal void add(string contact)
        {
            contacts.Add(contact, contact);
        }

        internal int find(string contact)
        {
          return contacts.Where(c => c.Value.Contains(contact)).Count();
        }
    }
}
