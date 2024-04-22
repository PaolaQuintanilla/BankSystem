using System;
using System.Collections.Generic;

namespace OPERACION_PAQL.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string Names { get; set; } = null!;

    public string MotherLastName { get; set; } = null!;

    public string FatherLastName { get; set; } = null!;

    public string Ci { get; set; } = null!;

    public DateTime Birthday { get; set; }

    public string? Gender { get; set; }

    public int Cellphone { get; set; }

    public string Email { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
}
