//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BugTrackingSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Bug
    {
        [Required]
        public int BugID { get; set; }
        [Required]
        public string Tracker { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public Nullable<System.DateTime> StartDate { get; set; }
        [Required]
        public string Priority { get; set; }
        [Required]
        public Nullable<System.DateTime> DueDate { get; set; }
        [Required]
        public string Assignee { get; set; }
        [Required]
        public string EstimatedTime { get; set; }
        [Required ]
        public string PercentageDone { get; set; }
    }
}
