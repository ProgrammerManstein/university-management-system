﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace WebApp.Models
{
    public partial class Teacher
    {
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Telephone { get; set; }

        [JsonIgnore]
        public virtual User UserNavigation { get; set; }
    }
}