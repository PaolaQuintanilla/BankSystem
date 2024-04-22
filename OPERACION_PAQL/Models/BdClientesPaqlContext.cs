using Microsoft.EntityFrameworkCore;

namespace OPERACION_PAQL.Models;

public partial class BdClientesPaqlContext : DbContext
{
    public BdClientesPaqlContext()
    {
    }

    public BdClientesPaqlContext(DbContextOptions<BdClientesPaqlContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=BD_CLIENTES_PAQL;TrustServerCertificate=True;user id=USUARIO;password=PASSWORD; persist security info=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Account__3214EC0727DDBCA6");

            entity.ToTable("Account");

            entity.Property(e => e.BankAccount)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.IncomeLevel).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.RegistrationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Customer).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__Account__Custome__59FA5E80");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Customer__3214EC0771ABBE48");

            entity.HasIndex(e => e.Ci, "UQ__Customer__32149A7A971D01DF").IsUnique();

            entity.Property(e => e.Birthday).HasColumnType("datetime");
            entity.Property(e => e.Ci)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CI");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FatherLastName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.MotherLastName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Names)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC070F5FF234");

            entity.HasIndex(e => e.Username, "UQ__Users__536C85E4ACF6A684").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__Users__A9D105349BCD1B1F").IsUnique();

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Password).HasMaxLength(64);
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
