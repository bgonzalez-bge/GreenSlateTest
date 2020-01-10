using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreenSlateChallenge.Models
{
    public class ProjectViewModel
    {
        public int Id { get; set; }
        public string StartDate { get; set; }
        public string TimeToStart { get; set; }
        public string EndDate { get; set; }
        public int Credits { get; set; }
        public string Status { get; set; }
}
}