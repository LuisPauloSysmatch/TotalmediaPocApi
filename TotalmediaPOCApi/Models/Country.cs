using System;
using System.ComponentModel.DataAnnotations;

namespace TotalmediaPOCApi.Models
{
    public class Country
    {
        /// <summary>
        /// Country Id
        /// </summary>
        [Key]
        public Guid CountryId { get; set; }

        /// <summary>
        /// Country name
        /// </summary>
        [Required]
        [MaxLength(250)]
        public string CountryName { get; set; }

    }
}
