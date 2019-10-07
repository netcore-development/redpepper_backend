using Microsoft.EntityFrameworkCore;
using RedPepper.API.Model;

namespace RedPepper.API.Data
{
    public class DbContextPostgreSql : DbContext
    {
        public DbContextPostgreSql(DbContextOptions<DbContextPostgreSql>options) : base(options) {}
        public DbSet<Persona> Personas{get;set;}
        public DbSet<Empleado> Empleados{get;set;}
        public DbSet<Cliente> Clientes{get;set;}

    }
}