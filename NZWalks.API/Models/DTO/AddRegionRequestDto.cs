﻿using System.ComponentModel.DataAnnotations;

namespace NZWalks.API.Models.DTO
{
    public class AddRegionRequestDto
    {
        [Required]
        [MinLength(3, ErrorMessage = "Code has to be a minimum of 3 caracteres!")]
        [MaxLength(3, ErrorMessage = "Code has to be a maximum of 3 caracteres!")]
        public string Code { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Code has to be a maximum of 100 caracteres!")]
        public string Name { get; set; }
        public string? RegionImageUrl { get; set; }
    }
}
