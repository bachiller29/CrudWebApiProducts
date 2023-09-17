using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Models
{
    public  class Product
    {
        [Key]
        [Column("IdProduct")]
        public int IdProduct { get; set; }

        [Column("NameProduct")]
        public string NameProduct { get; set; }

        [Column("CodeProduct")]
        public string CodeProduct { get; set; }

        [Column("DescriptionProduct")]
        public string DescriptionProduct { get; set; }

        [Column("Price")]
        public int Price { get; set; }
    }
}
