using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OPERACION_PAQL.Models;

public partial class User
{
    public int Id { get; set; }
    [Required(ErrorMessage ="Porfavor ingrese su Nombre de Usuario")]
    [Display(Name = "Ingrese su nombre de usuario:")]
    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;
    [Required(ErrorMessage = "Porfavor ingrese su Contraseña")]
    [Display(Name = "Ingrese su Contraseña:")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }
}
