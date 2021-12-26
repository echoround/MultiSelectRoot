using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SelectBoxDomain.Models
{
    public class Customer
    {

        [Key]
        public int? CustomerId { get; set; }

        // The customer GUID (customerauth) property is to emulate user credentials and have a unique user with forms per "session".
        // I did this to have a specific customer to get when repopulating the form for editing.
        // Not primary key because GUID is bad for indexing.
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(TypeName = "varchar(40)")]
        [JsonPropertyName("customerauth")]
        public string? CustomerAuth { get; set; } = String.Empty;

        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        [JsonPropertyName("customername")]
        [Required(ErrorMessage = "Name is required.")]
        public string CustomerName { get; set; } = String.Empty;

        [Required(ErrorMessage = "This field is required.")]
        [MinLength(1)]
        [JsonPropertyName("sectors")]
        public virtual IEnumerable<Sector>? Sectors { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [JsonPropertyName("agreed")]
        public bool? Agreed { get; set; }

    }
}
