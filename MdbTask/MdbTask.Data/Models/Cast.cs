using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MdbTask.Data.Models
{
    public class Cast
    {
        [Key]
        public int CastId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public ICollection<Media> Media { get; set; }
    }
}
