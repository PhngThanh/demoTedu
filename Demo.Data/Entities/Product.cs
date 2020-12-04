using Demo.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Demo.Data.Entities
{
   // [Table("Products")]
    public class Product
    {
        public int Id { get; set; }

       // [Required] //tự gen bảng đó quí dị dạng 1
        public string Note { get; set; }

        //dùng để map đó // hợp lý hơn dùng int
        public Status Status { get; set; }
    }
}
