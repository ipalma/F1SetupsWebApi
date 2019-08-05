using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    [Table("F1ControllerTypes")]
    public class F1ControllerType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdControllerType")]
        public int IdControllerType { get; set; }
        [Column("ControllerTypeName")]
        public string ControllerTypeName { get; set; }
        [Column("creationDate")]
        public DateTime creationDate { get; set; }
        [Column("modifiedDate")]
        public DateTime modifiedDate { get; set; }
        [Column("rowguid")]
        public Guid rowguid { get; set; }
    }
}
