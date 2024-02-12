using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp_LaptopMVC.Models
{
    [Table("Laptop")]
    public class Laptop
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price {  get; set; }
        public string RAM {  get; set; }
        public string OS { get; set; }
        public string CPU { get; set; }

    }
}