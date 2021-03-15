using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IssueTrackerApp2.Models
{
    public class Issue
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsResolved { get; set; }

        public Issue()
        {

        }
    }
}
