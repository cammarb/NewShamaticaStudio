//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ShamaticaStudioEntities : DbContext
    {
        public ShamaticaStudioEntities()
            : base("name=ShamaticaStudioEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Administrador> Administradores { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<DetalleReserva> DetalleReservas { get; set; }
        public virtual DbSet<Horario> Horarios { get; set; }
        public virtual DbSet<Instrumento> Instrumentos { get; set; }
        public virtual DbSet<Reserva> Reservas { get; set; }
        public virtual DbSet<ReservaInstrumento> ReservasInstrumentos { get; set; }
        public virtual DbSet<Sala> Salas { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
    }
}
