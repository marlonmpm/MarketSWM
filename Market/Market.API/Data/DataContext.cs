using Market.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Market.API.Data

{
    //DataContext va a tomar todas las propiedades de DbContext(Por medio de la herencia que es con los dos puntos)
    public class DataContext:DbContext //Con los dos puntos a una clase la ponemos a heredarDbContes heredar
    {
        /*Cada que creeemos una nueva entidad en la carpeta entitys aqui en el DataContext nos toca mapearla,
         para despues mandarla a la base de datos*/
        public DataContext(DbContextOptions<DataContext>options) : base(options) {
        

        }

        //MAPEO
        /*Hay que hacer refencias a los proyectos. de Market.WEB a Market.Shared y de Market.API a Market.Shared
         para que siempre encuentren todas las dependencias de shared y no salgan errores con linea roja de entidades 
        de otra carpeta. Despues si apareceran los Usings a estos errores(Son como los imports de java)*/
        public DbSet<Country>Countries { get; set; }//DbSet cada entidad nueva hacer esto.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
