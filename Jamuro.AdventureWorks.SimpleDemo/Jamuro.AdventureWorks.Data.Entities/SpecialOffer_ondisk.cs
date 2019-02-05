namespace Jamuro.AdventureWorks.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sales.SpecialOffer_ondisk")]
    public partial class SpecialOffer_ondisk
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SpecialOffer_ondisk()
        {
            SpecialOfferProduct_ondisk = new HashSet<SpecialOfferProduct_ondisk>();
        }

        [Key]
        public int SpecialOfferID { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal DiscountPct { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        [Required]
        [StringLength(50)]
        public string Category { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime EndDate { get; set; }

        public int MinQty { get; set; }

        public int? MaxQty { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ModifiedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecialOfferProduct_ondisk> SpecialOfferProduct_ondisk { get; set; }
    }
}
