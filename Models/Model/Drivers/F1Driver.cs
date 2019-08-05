using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    [Table("F1Drivers")]
    public class F1Driver
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdDriver")]
        public int IdDriver { get; set; }
        [Column("IdTeam")]
        public int IdTeam { get; set; }
        [Column("DriverName")]
        public string DriverName { get; set; }
        [Column("DriverLastName")]
        public string DriverLastName { get; set; }
        [Column("DriverAbbr")]
        public string DriverAbbr { get; set; }
        [Column("F1Season")]
        public int F1Season { get; set; }
        [Column("creationDate")]
        public DateTime creationDate { get; set; }
        [Column("modifiedDate")]
        public DateTime modifiedDate { get; set; }
        [Column("rowguid")]
        public Guid rowguid { get; set; }
    }
}
