namespace Jamuro.AdventureWorks.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HumanResources.vEmployeePersonTemporalInfo")]
    public partial class vEmployeePersonTemporalInfo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BusinessEntityID { get; set; }

        [StringLength(8)]
        public string Title { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string MiddleName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string JobTitle { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string MaritalStatus { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(1)]
        public string Gender { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short VacationHours { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short SickLeaveHours { get; set; }
    }
}
