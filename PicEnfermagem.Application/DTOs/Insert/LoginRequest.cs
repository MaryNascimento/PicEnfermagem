﻿using System.ComponentModel.DataAnnotations;

namespace PicEnfermagem.Application.DTOs.Insert;

public sealed class LoginRequest
{
    [Required(ErrorMessage = "O email deve ser informado.")]
    [EmailAddress(ErrorMessage = "Informe um email válido.")]
    public string Email { get; set; }
    [Required(ErrorMessage = "A senha deve ser informada.")]
    public string Password { get; set; }
}
