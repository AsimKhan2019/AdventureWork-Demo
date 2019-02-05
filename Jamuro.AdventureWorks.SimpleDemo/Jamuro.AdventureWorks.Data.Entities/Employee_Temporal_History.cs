namespace Jamuro.AdventureWorks.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HumanResources.Employee_Temporal_History")]
    public partial class Employee_Temporal_History
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BusinessEntityID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string NationalIDNumber { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(256)]
        public string LoginID { get; set; }

        public short? OrganizationLevel { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string JobTitle { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "date")]
        public DateTime BirthDate { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(1)]
        public string MaritalStatus { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(1)]
        public string Gender { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "date")]
        public DateTime HireDate { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short VacationHours { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short SickLeaveHours { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "datetime2")]
        public DateTime ValidFrom { get; set; }

        [Key]
        [Column(Order = 11, TypeName = "datetime2")]
        public DateTime ValidTo { get; set; }
    }
}
