using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    [Table("F1Teams")]
    public class F1Team
    {
        [Key]
        [Column("IdTeam")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTeam { get; set; }
        [Column("TeamName")]
        public string TeamName { get; set; }
        [Column("IdEngine")]
        public int IdEngine { get; set; }
        [Column("F1Season")]
        public int F1Season { get; set; }
        [Column("Headquarters")]
        public string Headquarters { get; set; }
        [Column("HeadquartersX")]
        public decimal HeadquartersX { get; set; }
        [Column("HeadquartersY")]
        public decimal HeadquartersY { get; set; }
        [Column("FoundationYear")]
        public int FoundationYear { get; set; }
        [Column("creationDate")]
        public DateTime creationDate { get; set; }
        [Column("modifiedDate")]
        public DateTime modifiedDate { get; set; }
        [Column("rowguid")]
        public Guid rowguid { get; set; }
    }
}
