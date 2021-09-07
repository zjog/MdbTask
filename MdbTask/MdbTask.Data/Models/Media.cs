using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static MdbTask.Data.Enums;

namespace MdbTask.Data.Models
{
    public class Media
    {
        [Key]
        public int MediaId { get; set; }

        [Required]
        public MediaType Type { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        [MaxLength(250)]
        public string Descritpion { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        public List<Rating> Ratings { get; set; }

        public ICollection<Cast> Cast { get; set; }
    }
}
