﻿using System.ComponentModel.DataAnnotations;

namespace Week6BlazerApp.Data.Models
{
    public class Programme
    {
        [Key]
        public int Id {  get; set; }
        public string Code {  get; set; }
        public string Title {  get; set; }
        public int Credits { get; set; }
        public DateTime Created {  get; set; }
    }
}
