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
        [Required]
        [Range(0, 100)]
        public string AssignmentsScore { get; set; }
        [Required]
        [Range(0, 100)]
        public string GroupProjectScore { get; set; }
        [Required]
        [Range(0, 100)]
        public string QuizzesScore { get; set; }
        [Required]
        [Range(0, 100)]
        public string ExamsScore { get; set; }
        [Required]
        [Range(0, 100)]
        public string IntexScore { get; set; }
    }
}
