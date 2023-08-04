﻿using System.ComponentModel.DataAnnotations;

namespace MeusLivrosAPI.Models;

public class Livraria
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatorio!")]
    public string Nome { get; set; }
}