using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Apicountry3.Models
{
    public class Country3
    {
        [Key]
        public string Name { get; set; }
        [Required]
        public string Capital { get; set; }
        public int Population { get; set; }
        public List<Double> Latlng { get; set; }
        public List<String> Timezones { get; set; }
        public List<Currency> Currencies { get; set; }
        public string Flag { get; set; }

    }
}