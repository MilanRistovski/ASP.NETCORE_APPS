using Domain_Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTO_Models.ApiModels
{
    public class EmailModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Headline { get; set; }
        public CategoryType Category { get; set; }
        public int UserId { get; set; }
    }
}
