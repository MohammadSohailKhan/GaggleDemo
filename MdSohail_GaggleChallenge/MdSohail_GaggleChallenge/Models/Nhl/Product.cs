using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace MdSohail_GaggleChallenge.Models.Nhl
{
    public class Product
    {
        [Key]
        [MaxLength(60)]
        public string GUID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedDate { get; set; }
        public bool Active { get; set; }
    }
}