﻿using System.ComponentModel.DataAnnotations;

namespace NewProject.DataDatamodels
{
    public class Login

    {
        [Key]
        public int Id { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }
    }
}
