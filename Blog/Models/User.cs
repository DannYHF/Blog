﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Blog.Attributes;
using Microsoft.AspNetCore.Identity;

namespace Blog.Models
{
    public class User : IdentityUser, ICreateTime
    {

        [Display(Name = "Имя")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Длина строки должна быть от 2 до 30 символов")]
        [Required(ErrorMessage = "Не коректная информация")]
        public string FirstName { get; set; }

        [Display(Name = "Фамилия")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Длина строки должна быть от 2 до 30 символов")]
        [Required(ErrorMessage = "Не коректная информация")]
        public string LastName { get; set; }

        [Display(Name = "Отображаемое имя(nickname)")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Длина строки должна быть от 2 до 30 символов")]
        [Required(ErrorMessage = "Не коректная информация")]
        public string NickName { get; set; }
        
        [Display(Name = "Фото профиля")]
        public byte[] Avatar { get; set; }

        public List<Article> Articles { get; set; }
        public DateTime CreateTime { get; set; }
        public User()
        {
            CreateTime = DateTime.Now;
        }
    }
}
