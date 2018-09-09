using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiAdventureWorks.Models.AdventureWorks.DTO
{
    public class PersonDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public IEnumerable<string> EmailAddresses { get; set; }
    }
}