﻿using System.ComponentModel.DataAnnotations;

namespace Cw11.DTOs.Requests
{
    public class ModifyDoctorDataRequest
    {
        [Required]
        public int IdDoctor { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
    }
}
