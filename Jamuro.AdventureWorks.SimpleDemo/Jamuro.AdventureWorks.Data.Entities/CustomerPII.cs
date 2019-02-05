namespace Jamuro.AdventureWorks.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sales.CustomerPII")]
    public partial class CustomerPII
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(11)]
        public string SSN { get; set; }

        [StringLength(25)]
        public string CreditCardNumber { get; set; }

        [StringLength(50)]
        public string EmailAddress { get; set; }

        [StringLength(25)]
        public string PhoneNumber { get; set; }

        public int? TerritoryID { get; set; }
    }
}
