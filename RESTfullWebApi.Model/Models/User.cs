﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTfullWebApi.Model.Models
{
  public class User 
  {
    [Key]
    public int Id { get; set; }
    public string? FirstName { get; set; }        
    public string? LastName { get; set; }
    public string? Username { get; set; }
    public string Password { get; set; }
    public byte[]? PasswordHash { get; set; }
    public byte[]? PasswordSalt { get; set; }
    public string? Email { get; set; }
    public string? Address { get; set; }
    public string? PhoneNumber { get; set; }
  }
}
