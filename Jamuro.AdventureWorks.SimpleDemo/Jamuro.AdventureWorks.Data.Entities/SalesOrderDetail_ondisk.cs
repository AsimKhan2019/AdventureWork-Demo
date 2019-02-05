namespace Jamuro.AdventureWorks.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sales.SalesOrderDetail_ondisk")]
    public partial class SalesOrderDetail_ondisk
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SalesOrderID { get; set; }

        [Key]
        [Column(Order = 1)]
        public long SalesOrderDetailID { get; set; }

        [StringLength(25)]
        public string CarrierTrackingNumber { get; set; }

        public short OrderQty { get; set; }

        public int ProductID { get; set; }

        public int SpecialOfferID { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPriceDiscount { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ModifiedDate { get; set; }

        public virtual SalesOrderHeader_ondisk SalesOrderHeader_ondisk { get; set; }

        public virtual SpecialOfferProduct_ondisk SpecialOfferProduct_ondisk { get; set; }
    }
}
