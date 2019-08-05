using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    [Table("F1RaceCircuits")]
    public class F1RaceCircuit
    {
        [Key]
        [Column("IdCircuit")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCircuit { get; set; }
        [Column("CircuitName")]
        public string CircuitName { get; set; }
        [Column("GPName")]
        public string GPName { get; set; }
        [Column("Country")]
        public string Country { get; set; }
        [Column("City")]
        public string City { get; set; }
        [Column("CoordX")]
        public decimal CoordX { get; set; }
        [Column("CoordY")]
        public decimal CoordY { get; set; }
        [Column("NumberOfTurns")]
        public int NumberOfTurns { get; set; }
        [Column("Description")]
        public string Description { get; set; }
        [Column("Distance")]
        public decimal Distance { get; set; }
        [Column("FullDistance")]
        public decimal FullDistance { get; set; }
        [Column("creationDate")]
        public DateTime creationDate { get; set; }
        [Column("modifiedDate")]
        public DateTime modifiedDate { get; set; }
        [Column("rowguid")]
        public Guid rowguid { get; set; }

    }
}
