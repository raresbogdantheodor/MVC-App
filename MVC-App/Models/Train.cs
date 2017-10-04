using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_App.Models
{
    public class Train : IValidatableObject
    {
        public int Id { get; set; }

        [Required]
        [Display(Name="Nume")]
        public string Name { get; set; }
        public TrainCategory? TrainType { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(Name.Length < 2 || Name.Length >= 10)
            {
                yield return new ValidationResult("Numele trebuie sa fie intre 2-10 caractere!");
            }
        }

        public enum TrainCategory
        {
            HighSpeed,
            Maglev,
            InterCity,
            ShortDistance
        }
    }
}