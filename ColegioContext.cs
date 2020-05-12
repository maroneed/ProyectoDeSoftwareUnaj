using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaORM
{
    class ColegioContext: DbContext
    {
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\servidor 1;Database=ColegioDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profesor>().Property(p => p.sueldo).HasColumnType("decimal(15, 2)");
            modelBuilder.Entity<Profesor>().Property(p => p.nombre).HasColumnType("varchar(45)");
            modelBuilder.Entity<Estudiante>().Property(e => e.nombre).HasColumnType("varchar(45)");
            modelBuilder.Entity<Curso>().Property(c => c.nombre).HasColumnType("varchar(45)");

            modelBuilder.Entity<Profesor>(entity =>

            entity.HasData(

                new Profesor  { profesorID = 1,nombre= "guepardo",sueldo = 15000}

                )

                );










        }
    }
}
