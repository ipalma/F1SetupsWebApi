using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    [Table("F1Engines")]
    public class F1Engine
    {
        [Key]
        [Column("IdEngine")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEngine { get; set; }
        [Column("EngineName")]
        public string EngineName { get; set; }
        [Column("F1Season")]
        public int F1Season { get; set; }
        [Column("HP")]
        public int HP { get; set; }
        [Column("creationDate")]
        public DateTime creationDate { get; set; }
        [Column("modifiedDate")]
        public DateTime modifiedDate { get; set; }
        [Column("rowguid")]
        public Guid rowguid { get; set; }
    }
}
