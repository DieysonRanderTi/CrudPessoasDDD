﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudPessoasDDD.MVC.Models
{
    public class UserRegisterModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirme a senha")]
        [Compare("Password", ErrorMessage = "As senhas não conferem")]
        public string ConfirmPassword { get; set; }
    }
}