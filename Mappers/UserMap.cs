
namespace BrotaAPI.Mappers
{
    public class UserMap : IEntityTypeConfiguration<User>, IEntityConfig
    {
        public UserMap() { }
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("users");

            builder.HasIndex(c => c.Id)
                .IsUnique();

            builder.Property(c => c.Id)
                .HasColumnName("user_id")
                .HasColumnType("int");


            builder.Property(c => c.Name)
                .HasColumnName("name")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(c => c.Email)
                .HasColumnName("email")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

            builder.Property(c => c.Password)
                .HasColumnName("password")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(c => c.PhoneNumber)
                .HasColumnName("phone_number")
                .HasColumnType("varchar(11)")
                .HasMaxLength(11);

            builder.Property(c => c.EmailVerificationDate)
                .HasColumnName("email_verificated_at")
                .HasColumnType("timestamp");

            builder.Property(c => c.PhoneNumberVerificationDate)
                .HasColumnName("phone_number_vificated_at")
                .HasColumnType("timestamp");

            builder.Property(c => c.VerificationDate)
                .HasColumnName("user_verificated_at")
                .HasColumnType("timestamp");

            builder.Property(c => c.CreationDate)
                .HasColumnName("created_at")
                .HasColumnType("timestamp");

            builder.Property(c => c.UpdateDate)
                .HasColumnName("updated_at")
                .HasColumnType("timestamp");

        }
    }
}
