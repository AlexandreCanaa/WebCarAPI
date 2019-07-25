using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using WebStoreAPI.Domain.Abstract;

namespace WebStoreAPI.Domain
{
    public sealed class Car : Entity {

        [Required]
        [StringLength(4)]
        string year;

        [Required]
        [MaxLength(99)]
        [MinLength(2)]
        string brand;

        [Required]
        [MaxLength(99)]
        [MinLength(2)]
        string model;
    }
}
