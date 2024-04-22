using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OPERACION_PAQL.Models;

public partial class Customer
{
    public int Id { get; set; }
    [Display(Name = "Nombres")]
    public string Names { get; set; } = null!;
    [Display(Name = "Apellido Materno")]
    public string MotherLastName { get; set; } = null!;
    [Display(Name = "Apellido Paterno")]
    public string FatherLastName { get; set; } = null!;

    public string Ci { get; set; } = null!;
    [Display(Name = "Fecha de Nacimiento")]
    public DateTime Birthday { get; set; }
    [Display(Name = "Genero")]
    public string? Gender { get; set; }
    [Display(Name = "Numero de Celular")]
    public int Cellphone { get; set; }
    [Display(Name = "Correo Electronico")]
    public string Email { get; set; } = null!;
    [Display(Name = "Fecha de Creacion")]
    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
}
