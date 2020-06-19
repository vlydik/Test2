using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Test2.Entities
{
    public class Context: DbContext
    {
        public DbSet<Pet> Pets { get; set; }
        public DbSet<BreedType> BreedTypes { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<Volunteer_Pet> Volunteer_Pets { get; set; }

        public Context()
        {

        }
        public Context(DbContextOptions options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);
            model.Entity<Pet>(entity =>
            {
                entity.HasKey(e => e.IdPet);
                entity.Property(e => e.IdPet).ValueGeneratedOnAdd();
                entity.Property(e => e.Name).IsRequired().HasMaxLength(80);

                //entity.HasOne(p => p.IdPet).WithMany(p => p.IdPets)

                var data = new List<Pet>();
                data.Add(new Pet { IdPet = 1, Name = "Dog" });
                data.Add(new Pet { IdPet = 2, Name = "Cat" });

                entity.HasData(data);
            }
            );
            model.Entity<Volunteer_Pet>(entity =>
            {
                entity.HasKey(e => e.IdVolunteer);
                entity.HasKey(e => e.IdPet);
                entity.Property(e => e.IdVolunteer).ValueGeneratedOnAdd();
                entity.Property(e => e.IdPet).ValueGeneratedOnAdd();
                entity.Property(e => e.DateAccepted).IsRequired();


            }
            );
            model.Entity<Volunteer>(entity =>
            {
                entity.HasKey(e => e.IdVolunteer);
                entity.HasKey(e => e.IdSuperVisor);
                entity.Property(e => e.IdVolunteer).ValueGeneratedOnAdd();
                entity.Property(e => e.IdSuperVisor).ValueGeneratedOnAdd();
                entity.Property(e => e.Name).IsRequired().HasMaxLength(80);
                entity.Property(e => e.Surname).IsRequired().HasMaxLength(80);
                entity.Property(e => e.Phone).IsRequired().HasMaxLength(30);
                entity.Property(e => e.Address).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(80);
                entity.Property(e => e.StartingDate).IsRequired();


                





            });
            model.Entity<BreedType>(entity =>
            {
                entity.HasKey(e => e.IdBreedType);
                entity.Property(e => e.IdBreedType).ValueGeneratedOnAdd();
                entity.Property(e => e.Name).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Description).IsRequired().HasMaxLength(500);

            });
        }
    }
}
