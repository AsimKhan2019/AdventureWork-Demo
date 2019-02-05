namespace Jamuro.AdventureWorks.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Production.Product_inmem")]
    public partial class Product_inmem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product_inmem()
        {
            SpecialOfferProduct_inmem = new HashSet<SpecialOfferProduct_inmem>();
        }

        [Key]
        public int ProductID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(25)]
        public string ProductNumber { get; set; }

        public bool MakeFlag { get; set; }

        public bool FinishedGoodsFlag { get; set; }

        [StringLength(15)]
        public string Color { get; set; }

        public short SafetyStockLevel { get; set; }

        public short ReorderPoint { get; set; }

        [Column(TypeName = "money")]
        public decimal StandardCost { get; set; }

        [Column(TypeName = "money")]
        public decimal ListPrice { get; set; }

        [StringLength(5)]
        public string Size { get; set; }

        [StringLength(3)]
        public string SizeUnitMeasureCode { get; set; }

        [StringLength(3)]
        public string WeightUnitMeasureCode { get; set; }

        public decimal? Weight { get; set; }

        public int DaysToManufacture { get; set; }

        [StringLength(2)]
        public string ProductLine { get; set; }

        [StringLength(2)]
        public string Class { get; set; }

        [StringLength(2)]
        public string Style { get; set; }

        public int? ProductSubcategoryID { get; set; }

        public int? ProductModelID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SellStartDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? SellEndDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DiscontinuedDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ModifiedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecialOfferProduct_inmem> SpecialOfferProduct_inmem { get; set; }
    }
}
