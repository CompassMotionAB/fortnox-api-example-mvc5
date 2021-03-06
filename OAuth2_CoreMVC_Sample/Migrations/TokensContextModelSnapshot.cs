using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using FortnoxApiExample.Models;

namespace FortnoxApiExample.Migrations
{
    [DbContext(typeof(TokensContext))]
    internal class TokensContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("OAuth2_CoreMVC_Sample.Models.Token", b =>
            {
                b.Property<string>("RealmId")
                    .HasColumnType("TEXT")
                    .HasMaxLength(50);

                b.Property<int>("ScopeHash")
                    .IsRequired()
                    .HasColumnType("INTEGER");

                b.Property<string>("AccessToken")
                    .IsRequired()
                    .HasColumnType("TEXT")
                    .HasMaxLength(1000);

                b.Property<string>("RefreshToken")
                    .IsRequired()
                    .HasColumnType("TEXT")
                    .HasMaxLength(1000);
               
                b.HasKey("RealmId");

                b.ToTable("Token");
            });
#pragma warning restore 612, 618
        }
    }
}