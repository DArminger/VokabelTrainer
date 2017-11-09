using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB_lib.Entities
{
    [Table("WordGroups")]
    public class WordGroup
    {
        [Key]
        public int WordGroupId { get; set; }
        [Required]
        public string Word_en { get; set; }
        [Required]
        public string Word_ge { get; set; }
        [Required]
        public virtual Category Category { get; set; }
    }
}
