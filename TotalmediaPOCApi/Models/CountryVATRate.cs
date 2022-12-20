using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TotalmediaPOCApi.Models
{
    public class CountryVATRate
    {
        /// <summary>
        /// Country VAT Rate Id
        /// </summary>
        [Key]
        public Guid CountryVATRateId { get; set; }

        /// <summary>
        /// Country VAT Rate value
        /// </summary>
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal CountryVATRateValue { get; set; }

        /// <summary>
        /// Country Id
        /// </summary>
        [Required]
        public Guid CountryId { get; set; }

    }
}
