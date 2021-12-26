using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SelectBoxAPI.Models
{
    public class Sector
    {

        [Key]
        public int? SectorId { get; set; }

        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        [JsonPropertyName("sectorname")]
        [Required]
        public string? SectorName { get; set; }

        [ForeignKey(nameof(Customer))]
        [JsonIgnore]
        public int? CustomerId { get; set; }

        public override string ToString() => SectorName ?? String.Empty;

    }
}

