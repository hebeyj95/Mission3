using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission2.Models
{
    public class GradeCalculatorModel
    {
        private const int V = 100;
        [Required]
        [Range(0, V)]
        public string AssignmentsScore { get; set; }
        [Required]
        [Range(0, V)]
        public string GroupProjectScore { get; set; }
        [Required]
        [Range(0, V)]
        public string QuizzesScore { get; set; }
        [Required]
        [Range(0, V)]
        public string ExamsScore { get; set; }
        [Required]
        [Range(0, V)]
        public string IntexScore { get; set; }
    }
}
