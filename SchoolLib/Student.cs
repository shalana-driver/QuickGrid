﻿using System.ComponentModel.DataAnnotations;

namespace SchoolLib;

public class Student {
  public int StudentId { get; set; }
  [Required]
  public string? FirstName { get; set; }
  [Required]
  public string? LastName { get; set; }
  [Required]
  public string? School { get; set; }

}

