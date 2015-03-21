﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReactFluxModelState.Models
{
    public class Person
    {
        [Required]
        public string Name { get; set; }

        [Range(0, 200)]
        public int Age { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public DateTime BirthDate { get; set; }

        [Required, MaxLength(5)]
        public ICollection<Pet> Pets { get; set; }
    }

    public class Pet
    {
        [Required]
        public string Name { get; set; }

        [MinLength(5)]
        public string Species { get; set; }

        [Range(0, 50)]
        public int Age { get; set; }

        public DateTime BirthDate { get; set; }
    }
}