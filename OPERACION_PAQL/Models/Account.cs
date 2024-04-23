using System.ComponentModel.DataAnnotations;

namespace OPERACION_PAQL.Models;

public partial class Account
{
    public int Id { get; set; }
    [Display(Name = "Id Cliente")]
    public int? CustomerId { get; set; }
    [Display(Name = "Cuenta de Banco")]

    public string BankAccount { get; set; } = null!;
    [Display(Name = "Nivel de Ingresos")]

    public decimal IncomeLevel { get; set; }
    
    [Display(Name = "Fecha de Registro")]
    public DateTime? RegistrationDate { get; set; }

    [Display(Name = "Fecha de Actualizacion")]
    public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;

    public virtual Customer? Customer { get; set; }
}
