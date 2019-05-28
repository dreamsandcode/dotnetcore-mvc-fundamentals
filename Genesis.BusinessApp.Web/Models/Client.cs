using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Genesis.BusinessApp.Web.Models
{
    public partial class Client
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Client ID")]
        public int ClientId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(50, ErrorMessage = "Do not enter more than 50 characters")]
        [Display(Name = "Client Name")]
        public string Client1 { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(50, ErrorMessage = "Do not enter more than 50 characters")]
        [Display(Name = "Address Line 1")]
        public string Address1 { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(50, ErrorMessage = "Do not enter more than 50 characters")]
        [Display(Name = "Address Line 2")]
        public string Address2 { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(50, ErrorMessage = "Do not enter more than 50 characters")]
        public string City { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(2, ErrorMessage = "Do not enter more than 2 characters")]
        [Display(Name = "Province")]
        public string Pr { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(15, ErrorMessage = "Do not enter more than 15 characters")]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
    }
}
