namespace OPERACION_PAQL.Models;

public partial class Account
{
    public int Id { get; set; }

    public int? CustomerId { get; set; }

    public string BankAccount { get; set; } = null!;

    public decimal IncomeLevel { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public DateTime UpdatedDate { get; set; }

    public virtual Customer? Customer { get; set; }
}
