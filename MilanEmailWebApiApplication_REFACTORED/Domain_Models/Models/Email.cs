using Domain_Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain_Models.Models
{
    [Table("Emails")]
    public class Email
    {
        [Key] //defines the primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(400)]
        [Required]
        public string Text { get; set; }

        [MinLength(15)]
        public string Headline { get; set; }

        public CategoryType Category { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }

        public virtual User User { get; set; }

    }
}
