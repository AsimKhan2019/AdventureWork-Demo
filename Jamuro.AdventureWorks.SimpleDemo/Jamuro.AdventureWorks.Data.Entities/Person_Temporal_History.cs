namespace Jamuro.AdventureWorks.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Person.Person_Temporal_History")]
    public partial class Person_Temporal_History
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BusinessEntityID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string PersonType { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool NameStyle { get; set; }

        [StringLength(8)]
        public string Title { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string MiddleName { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(10)]
        public string Suffix { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmailPromotion { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "datetime2")]
        public DateTime ValidFrom { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "datetime2")]
        public DateTime ValidTo { get; set; }
    }
}
