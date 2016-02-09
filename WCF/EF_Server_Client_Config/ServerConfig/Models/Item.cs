using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerConfig.Models
{
    public class Item
    {
        [Required]
        public int ItemId { get; set; }
        [MaxLength(30)]
        public string ItemName { get; set; }
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }
    }
}
