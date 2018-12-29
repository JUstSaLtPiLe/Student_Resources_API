﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentResourcesAPI.Models
{
    public class Grade
    {
        [Key]
        [Column(Order = 1)]
        public int AccountId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int SubjectId { get; set; }
        public float Mark { get; set; }
        public GradeType GradeType { get; set; }
        public GradeStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public Account Account { get; set; }
        public Subject Subject { get; set; }

        // create constructor
    }

    public enum GradeStatus
    {
        Failed = 0,
        Passed = 1,
    }

    public enum GradeType
    {
        AssignmentGrade = 1,
        PracticeGrade = 2,
    }
}