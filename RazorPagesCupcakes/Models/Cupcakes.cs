﻿using System.ComponentModel.DataAnnotations;

namespace RazorPagesCupcakes.Models;

public class Cupcakes
{
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }
    public bool IsGlutenFree { get; set; }

    [Range(0.01, 9999.99)]
    public decimal Price { get; set; }
}