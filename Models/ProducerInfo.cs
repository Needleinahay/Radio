﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ProducerInfo
    {
        [Key, ForeignKey("Author")]
        public int AuthorId { get; set; }

        public string PhoneNumber { get; set; }
        public string Schedule { get; set; }

        public virtual Author Author { get; set; }
    }
}
