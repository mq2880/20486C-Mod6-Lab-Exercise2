using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;


namespace ButterfliesShop.Models
{
    public class Butterfly
    {
        [Display(Name = "Common Name:")]
        public int Id { get; set; }

        public string CommonName { get; set; }

        [Display(Name = "Butterfly Family:")]
        public Family? ButterflyFamily { get; set; }
        
        [Display(Name = "Butterflies Quantity:")]
        public int? Quantity { get; set; }

        [Display(Name = "Characteristics:")]
        public string Characteristics { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Updated on:")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        public DateTime CreatedDate { get; set; }
        public IFormFile PhotoAvatar { get; set; }
        public string ImageName { get; set; }

        [Display(Name = "Butterflies Picture:")]
        public byte[] PhotoFile { get; set; }
        public string ImageMimeType { get; set; }
    }
}
