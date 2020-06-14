﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cw11.DTOs.Requests
{
    public class AddDoctorRequest
    {
        [Required]
        [MaxLength(100)]
        public string FirstName {get; set;}
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
    }
}