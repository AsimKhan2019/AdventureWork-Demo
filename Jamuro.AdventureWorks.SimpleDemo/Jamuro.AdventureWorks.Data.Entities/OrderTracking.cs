namespace Jamuro.AdventureWorks.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sales.OrderTracking")]
    public partial class OrderTracking
    {
        public int OrderTrackingID { get; set; }

        public int SalesOrderID { get; set; }

        [StringLength(25)]
        public string CarrierTrackingNumber { get; set; }

        public int TrackingEventID { get; set; }

        [Required]
        [StringLength(2000)]
        public string EventDetails { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime EventDateTime { get; set; }
    }
}
