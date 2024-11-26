using System;
using System.ComponentModel.DataAnnotations;

namespace MVCinMemoryCRUD.Models{
    public class Customer{
        [Key]
        public int CustomerId {get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime DOB { get; set; }
        public string PAN_Number { get; set; }
    }
}