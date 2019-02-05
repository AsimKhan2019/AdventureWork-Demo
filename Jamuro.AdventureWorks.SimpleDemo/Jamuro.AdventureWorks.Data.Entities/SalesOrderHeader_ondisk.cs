namespace Jamuro.AdventureWorks.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sales.SalesOrderHeader_ondisk")]
    public partial class SalesOrderHeader_ondisk
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SalesOrderHeader_ondisk()
        {
            SalesOrderDetail_ondisk = new HashSet<SalesOrderDetail_ondisk>();
        }

        [Key]
        public int SalesOrderID { get; set; }

        public byte RevisionNumber { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime OrderDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DueDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ShipDate { get; set; }

        public byte Status { get; set; }

        public bool OnlineOrderFlag { get; set; }

        [StringLength(25)]
        public string PurchaseOrderNumber { get; set; }

        [StringLength(15)]
        public string AccountNumber { get; set; }

        public int CustomerID { get; set; }

        public int SalesPersonID { get; set; }

        public int? TerritoryID { get; set; }

        public int BillToAddressID { get; set; }

        public int ShipToAddressID { get; set; }

        public int ShipMethodID { get; set; }

        public int? CreditCardID { get; set; }

        [StringLength(15)]
        public string CreditCardApprovalCode { get; set; }

        public int? CurrencyRateID { get; set; }

        [Column(TypeName = "money")]
        public decimal SubTotal { get; set; }

        [Column(TypeName = "money")]
        public decimal TaxAmt { get; set; }

        [Column(TypeName = "money")]
        public decimal Freight { get; set; }

        [StringLength(128)]
        public string Comment { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ModifiedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderDetail_ondisk> SalesOrderDetail_ondisk { get; set; }
    }
}
