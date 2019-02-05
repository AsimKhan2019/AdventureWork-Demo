namespace Jamuro.AdventureWorks.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sales.TrackingEvent")]
    public partial class TrackingEvent
    {
        public int TrackingEventID { get; set; }

        [Required]
        [StringLength(255)]
        public string EventName { get; set; }
    }
}
