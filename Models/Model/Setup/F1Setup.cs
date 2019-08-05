using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    [Table("F1Setups")]
    public class F1Setup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdSetup")]
        public int IdSetup { get; set; }
        [Column("IdGameType")]
        public int IdGameType { get; set; }
        [Column("IdCircuit")]
        public int IdCircuit { get; set; }
        [Column("IdTeam")]
        public int IdTeam { get; set; }
        [Column("Weather")]
        public string Weather { get; set; }
        [Column("IdControllerType")]
        public int IdControllerType { get; set; }
        [Column("FrontWingAero")]
        public int FrontWingAero { get; set; }
        [Column("RearWingAero")]
        public int RearWingAero { get; set; }
        [Column("DifferentialOnThrottle")]
        public int DifferentialOnThrottle { get; set; }
        [Column("DifferentialOffThrottle")]
        public int DifferentialOffThrottle { get; set; }
        [Column("FrontCamber")]
        public decimal FrontCamber { get; set; }
        [Column("RearCamber")]
        public decimal RearCamber { get; set; }
        [Column("FrontToe")]
        public decimal FrontToe { get; set; }
        [Column("RearToe")]
        public decimal RearToe { get; set; }
        [Column("FrontSuspension")]
        public int FrontSuspension { get; set; }
        [Column("RearSuspension")]
        public int RearSuspension { get; set; }
        [Column("FrontAntiRollBar")]
        public int FrontAntiRollBar { get; set; }
        [Column("RearAntiRollBar")]
        public int RearAntiRollBar { get; set; }
        [Column("FrontRideHeight")]
        public int FrontRideHeight { get; set; }
        [Column("RearRideHeight")]
        public int RearRideHeight { get; set; }
        [Column("BrakePressure")]
        public int BrakePressure { get; set; }
        [Column("FrontBrakeBias")]
        public int FrontBrakeBias { get; set; }
        [Column("FrontTyrePressure")]
        public decimal FrontTyrePressure { get; set; }
        [Column("RearTyrePressure")]
        public decimal RearTyrePressure { get; set; }
        [Column("Ballast")]
        public int Ballast { get; set; }
        [Column("creationDate")]
        public DateTime creationDate { get; set; }
        [Column("modifiedDate")]
        public DateTime modifiedDate { get; set; }
        [Column("rowguid")]
        public Guid rowguid { get; set; }
    }
}
